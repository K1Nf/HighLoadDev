using AutoMapper;
using CSharpFunctionalExtensions;
using HighLoadDevelopment.Contracts;
using HighLoadDevelopment.Contracts.DTO;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;

namespace HighLoadDevelopment.Services
{
    public class VisitService(AppDbContext _context, IMapper _mapper)
    {
        public async Task<Result<List<MeetingDTO>>> GetMeetingsByUserId(Guid userId)
        {
            var visits = await _context.Visits
                .Where(v => v.UserId == userId)
                .Include(v => v.Meeting)
                .ToListAsync();

            var meetingsDTO = visits
                .Select(v => v.Meeting)
                .Select(_mapper.Map<MeetingDTO>)
                .ToList();


            return Result.Success(meetingsDTO);
        }


        public async Task<Result<List<UserShortDTO>>> GetUsersByMeetingId(Guid meetingId)
        {
            var visits = await _context.Visits
                .Where(v => v.MeetingId == meetingId)
                .Include(v => v.User)
                .ToListAsync();

            var usersDTO = visits
                .Select(v => v.User)
                .Select(_mapper.Map<UserShortDTO>)
                .ToList();

            return Result.Success(usersDTO);
        }



        public async Task<Result> CancelRegistration(Guid meetingId, Guid userId)
        {
            //var rows = await _context.Visits
            //    .Where(v => v.UserId == userId && v.MeetingId == meetingId)
            //        .ExecuteUpdateAsync(u => u
            //            .SetProperty(p => p.Deleted_At, DateTime.UtcNow)
            //            .SetProperty(p => p.Deleted_By, userId));


            var rows = await _context.Visits
                .Where(v => v.UserId == userId && v.MeetingId == meetingId)
                .ExecuteDeleteAsync();

            await _context.SaveChangesAsync();

            if (rows == 1)
                return Result.Success();

            return Result.Failure("");
        }


        public async Task<Result> AddRegistration(Guid meetingId, Guid userId)
        {
            var visit = new Visit()
            {
                UserId = userId,
                MeetingId = meetingId,
                Created_By = userId,
            };

            await _context.Visits.AddAsync(visit);
            await _context.SaveChangesAsync();

            return Result.Success();
        }
    }
}
