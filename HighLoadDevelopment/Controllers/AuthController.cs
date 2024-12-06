using CSharpFunctionalExtensions;
using HighLoadDevelopment.Contracts.Requests;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Interfaces;
using HighLoadDevelopment.JWT;
using HighLoadDevelopment.Libraries;
using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighLoadDevelopment.Controllers
{
    [Route("api/ref/[controller]")]
    [ApiController]
    public class AuthController(AppDbContext _context, IPasswordHasher _passwordHasher, IJwtProvider _jwtProvider) : ControllerBase
    {

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest loginRequest)
        {
            //validation

            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.UserName == loginRequest.Login || u.Email == loginRequest.Login);

            if (user == null)
            {
                return BadRequest("Неправильный логин");
            }

            if (_passwordHasher.VerifyPassword(loginRequest.Password, user.Password))
            {
                string token = _jwtProvider.CreateNewToken(user.Id, user.UserName);
                Response.Cookies.Append("NeToKeN", token);
                Response.Cookies.Append("MeetUserName", user.UserName);
                return Ok();
            }

            return NotFound("Неправильный пароль");
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromForm] RegisterRequest registerRequest)
        {
            //validation

            var user = Models.User.CreateUser(registerRequest.FirstName, registerRequest.SecondName, registerRequest.LastName,
                registerRequest.UserName, registerRequest.Email, registerRequest.City,
                DateOnly.Parse(registerRequest.BirthDay), registerRequest.Password);

            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return Ok();
        }



        [HttpPost("changepassword")]
        public async Task<IActionResult> ChangePassword([FromForm] ChangePasswordRequest changePasswordRequest)
        {
            //validation
            Guid tokenId = Guid.Parse("c614cab9-7315-4212-9fa5-e1642bc3bb05");

            string oldPassword = _context.Users.FirstOrDefault(u => u.Id == tokenId)!.Password;

            if(oldPassword == changePasswordRequest.OldPassword)
            {
                await _context.Users
                    .Where(u => u.Id == tokenId)
                        .ExecuteUpdateAsync(u => u
                            .SetProperty(p => p.Password, changePasswordRequest.NewPassword));
                return Ok();
            }

            return BadRequest("Старый пароль неверен");
        }


        [HttpPost("signout")]
        public async Task<IActionResult> SignOut()
        {
            Response.Cookies.Delete("NeToKeN");
            return Ok();
        }
    }
}
