using AutoMapper;
using HighLoadDevelopment.Contracts;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HighLoadDevelopment.Services;
using HighLoadDevelopment.Contracts.Requests;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace HighLoadDevelopment.Controllers
{
    [ApiController]
    [Route("api/ref/[controller]")]
    [Authorize]
    public class UserApiController(UserService userService, MeetingService meetingService, VisitService visitService) : ControllerBase
    {
        private readonly UserService _userService = userService;
        private readonly MeetingService _meetingService = meetingService;
        private readonly VisitService _visitService = visitService;

        [HttpGet("{id:guid?}")]
        [HttpGet()]
        public async Task<IActionResult> GetUserById([FromRoute] Guid? id)
        {
            Guid userId = id ?? Guid.Parse(User.FindFirst("UserIdentity")!.Value);
            var userDTO = await _userService.GetUserById(userId);

            if (userDTO == null)
            {
                return BadRequest();
            }

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles, // Игнорирует циклические ссылки
                WriteIndented = true // Для удобства чтения
            };

            var myMeetingsDTO = await _meetingService.GetMeetingsByUserId(userId);
            var guestMeetingsDTO = await _meetingService.GetMeetingsToVisitByUserId(userId);


            string json = System.Text.Json.JsonSerializer.Serialize(userDTO, options);

            var response = System.Text.Json.JsonSerializer.Deserialize<UserDTO>(json);
            return Ok(response);
        }



        [HttpGet("users")]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _userService.GetUsers();

            return Ok(users.Value);
        }



        [HttpPut("update")]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateRequest userUpdateRequest)
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            var result = await _userService.EditUser(userUpdateRequest, userId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok();
        }



        [HttpGet("verify/{userId:guid}")]
        public async Task<IActionResult> CheckIfUserIsAuthor([FromRoute] Guid userId)
        {
            var tokenId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);
            bool verified = false;

            if (tokenId == userId)
            {
                verified = true;
            }
            return Ok(verified);
        }



        [HttpGet("check/{meetId:guid}")]
        public async Task<IActionResult> CheckOwner([FromRoute] Guid meetId)
        {
            var userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            var result = await _userService.CheckIfUserIsOwner(meetId, userId);

            return Ok(result.Value);
        }


        [HttpGet("visits/{meetId:guid}")]
        public async Task<IActionResult> GetVisits([FromRoute] Guid meetId)
        {
            var usersDTO = await _visitService.GetUsersByMeetingId(meetId);
            return Ok(usersDTO.Value);
        }
    }
}