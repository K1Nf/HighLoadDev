using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HighLoadDevelopment.Controllers.PagesControllers
{
    [Route("meets")]
    [ApiController]
    [Authorize]
    public class MeetingPageController : ControllerBase
    {

        // страница встречи
        [HttpGet("{id:guid}")]
        public async Task GetMeetingPage(Guid id)
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/meets/meet.html");
        }


        // страница список встреч
        [HttpGet("")]
        [HttpGet("/")]
        public async Task GetMeetingsPage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/index.html");
        }


        // страница создания встречи
        [HttpGet("create")]
        public async Task GetMeetingCreatePage()
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/meets/create.html");
        }


        // страница обновления встречи
        [HttpGet("update/{id:guid}")]
        public async Task GetMeetingUpdatePage(Guid id)
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/meets/update.html");
        }


        // страница удаления встречи
        [HttpGet("cancel/{id:guid}")]
        public async Task GetMeetingDeletePage(Guid id)
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/meets/cancel.html");
        }



        [HttpGet("search")]
        public async Task GetMeetingSearchPage(Guid id)
        {
            Response.ContentType = "text/html; charset=utf-8";
            await Response.SendFileAsync("wwwroot/html/meets/search.html");
        }
    }
}
