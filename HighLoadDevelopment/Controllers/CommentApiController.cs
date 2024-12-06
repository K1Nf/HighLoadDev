using HighLoadDevelopment.Contracts.DTO;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HighLoadDevelopment.Controllers
{
    [Route("api/ref/[controller]")]
    [ApiController]
    public class CommentApiController(AppDbContext _context) : ControllerBase
    {

        [Authorize]
        [HttpPost("create")]
        public async Task<IActionResult> CreateComment([FromBody] CreateCommentRequest createCommentRequest)
        {
            Guid userId = Guid.Parse(User.FindFirst("UserIdentity")!.Value);

            Comment comment = new Comment()
            {
                CommentText = createCommentRequest.Text,
                Created_At = DateTime.UtcNow,
                Created_By = userId,
                MeetingId = createCommentRequest.MeetId,
                UserId = userId,
                Id = Guid.NewGuid()
            };

            await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();

            return Created();
        }



        [Authorize]
        [HttpGet("meet/{meetId:guid}")]
        public async Task<IActionResult> GetCommentsByMeetId(Guid meetId)
        {
            var comments = await _context.Comments
                .Include(c => c.User)
                .AsNoTracking()
                .Where(c => c.MeetingId == meetId)
                .ToListAsync();

            return Ok(comments);
        }
    }
}
