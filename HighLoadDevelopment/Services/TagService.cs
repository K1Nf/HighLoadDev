using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;

namespace HighLoadDevelopment.Services
{
    public class TagService(AppDbContext context)
    {
        private readonly AppDbContext _context = context;

        public async Task<List<Tag>> GetTags() => await _context.Tags.ToListAsync();
    }
}
