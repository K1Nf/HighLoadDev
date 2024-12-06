using CSharpFunctionalExtensions;
using HighLoadDevelopment.Contracts;
using HighLoadDevelopment.Contracts.Requests;
using HighLoadDevelopment.Models;
using HighLoadDevelopment.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace HighLoadDevelopment.Controllers
{
    [Route("api/ref/[controller]")]
    [ApiController]
    [Authorize]
    public class MeetingApiController(MeetingService _meetingService, VisitService _visitService) : ControllerBase
    {

        [HttpGet("")]
        public async Task<IActionResult> GetMeetingsAsync()
        {
            var meetingsDTO = await _meetingService.GetMeetings();

            var options = new JsonSerializerOptions
            {
                ReferenceHandler = ReferenceHandler.IgnoreCycles, // Игнорирует циклические ссылки
                WriteIndented = true // Для удобства чтения
            };


            string json = JsonSerializer.Serialize(meetingsDTO.Value, options);

            var response = JsonSerializer.Deserialize<List<MeetingDTO>>(json);

            return Ok(response);
        }



        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetMeetingByIdAsync([FromRoute] Guid Id) // eventId
        {
            var meeting = await _meetingService.GetMeetingById(Id);

            if (meeting.IsFailure)
            {
                return BadRequest();
            }

            return Ok(meeting.Value);
        }



        [HttpPost("create")]
        public async Task<IActionResult> CreateMeetingAsync([FromBody] CreateMeetingRequest createMeetingRequest)
        {
            //Guid tokenId = Guid.NewGuid();
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);
            //Guid tokenId = Guid.Parse(User.FindFirst(jwtConfiguration.UserIdentity)!.Value);
            var meetingResult = await _meetingService.CreateMeeting(createMeetingRequest, userId);


            return Created();
        }


        [HttpPut("update/{meetingId:guid}")]
        [Authorize]
        public async Task<IActionResult> UpdateMeetingAsync([FromRoute] Guid meetingId, [FromBody] UpdateMeetingRequest updateMeetingRequest)
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);
            var result = await _meetingService.EditMeeting(updateMeetingRequest, meetingId, userId);

            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }
            return Ok();
        }


        [Authorize]
        public async Task<IActionResult> GetMeetingsToVisitByUserIdAsync()
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            var meetingsDTO = await _visitService.GetMeetingsByUserId(userId); //userId

            return Ok(meetingsDTO.Value);
        }


        [HttpDelete("Delete/{id:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid Id)
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);
            var result = await _meetingService.DeleteMeetingById(Id, userId);

            if (result.IsFailure)
            {
                return NotFound(result.Error);
            }

            return NoContent();
        }



        [HttpPost("join/{meetId:guid}")]
        public async Task<IActionResult> AddRegistrationAsync([FromRoute] Guid meetId)
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            Result result = await _visitService.AddRegistration(meetId, userId);
            
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok();
        }



        [HttpPost("leave/{meetId:guid}")]
        public async Task<IActionResult> LeaveMeetAsync([FromRoute] Guid meetId) // eventId
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            Result result = await _visitService.CancelRegistration(meetId, userId);
           
            if (result.IsFailure)
            {
                return BadRequest(result.Error);
            }

            return Ok();
        }


        [HttpGet("search")]
        public async Task<IActionResult> FindMeetsByParamsGetDataAsync([FromQuery] MeetingSearchRequest meetingSearchRequest) // eventId
        {
            var meetingDTO = await _meetingService.FindMeetingsByParams(meetingSearchRequest);

            return Ok(meetingDTO.Value);
            //return Ok(meetingResponse.Value);
        }



        //[HttpGet]
        //[Route("CheckInfo")]
        //public async Task<IResult> CheckUserInfoOnEvent([AsParameters] Guid eventId)
        //{
        //    Guid userId = Guid.Parse(User.FindFirst(jwtConfiguration.UserIdentity)!.Value);

        //    var userInfo = await _eventService.GetUserInfoOnEvent(userId, eventId);

        //    return Results.Ok(userInfo.Value);
        //}
    }
}
