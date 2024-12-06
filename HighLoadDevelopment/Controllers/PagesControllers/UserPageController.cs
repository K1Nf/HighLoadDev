using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HighLoadDevelopment.Controllers.PagesControllers
{
    [ApiController]
    [Route("user")]
    [Authorize]
    public class UserPageController : ControllerBase
    {

        [HttpGet("{id:guid?}")]
        [HttpGet]
        public async Task GetUserPage(Guid? id)
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/users/account.html");
        }


        [HttpGet("edit")]
        public async Task GetUserEditPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/users/Update.html");
        }


        //[HttpGet("/users")]
        //public IActionResult GetUsersPage()
        //{
        //    return Ok();
        //}
    }
}
