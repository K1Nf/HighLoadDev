using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using HighLoadDevelopment.Services;
using CSharpFunctionalExtensions;

namespace HighLoadDevelopment.Services
{
    public class AdminService(AppDbContext context, MeetingService meetingService)
    {
        private readonly AppDbContext _context = context;
        private readonly MeetingService _meetingService = meetingService;



        public async Task<Result> GetEventsForAdmin()
        {
            //var allEvents = await _context.Events
            //    .IgnoreQueryFilters()
            //    .Include(ev => ev.User)
            //    .OrderByDescending(ev => ev.Created)
            //    .ToListAsync();

            ////allEvents.ForEach(async ev => await _eventService.ChangeEventStatusInDataBase(ev));

            //return allEvents;
            return Result.Failure("");
        }
        
        public async Task<List<User>> GetUsersForAdmin() => await _context.Users.ToListAsync();
        public async Task<List<Tag>> GetTagsForAdmin() => await _context.Tags.ToListAsync();

    }
}
