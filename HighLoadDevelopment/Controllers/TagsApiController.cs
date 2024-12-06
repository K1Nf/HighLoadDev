using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HighLoadDevelopment.Controllers
{
    [Route("api/ref/[controller]")]
    [ApiController]
    [Authorize]
    public class TagsApiController(AppDbContext _context) : ControllerBase
    {

        [HttpGet]
        public async Task<List<Tag>> GetTags()
        {
            return await _context.Tags.ToListAsync();
        }
    }
}
