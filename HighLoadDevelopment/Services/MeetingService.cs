
using AutoMapper;
using CSharpFunctionalExtensions;
using HighLoadDevelopment.Contracts;
using HighLoadDevelopment.Contracts.Requests;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Transactions;

namespace HighLoadDevelopment.Services
{
    public class MeetingService(IMapper mapper, AppDbContext context, VisitService _visitService /*ICacheService cacheService*/)
    {
        private readonly IMapper _mapper = mapper;
        private readonly AppDbContext _context = context;
        //private readonly ICacheService _cacheService = cacheService;


        public async Task<Result<MeetingDTO>> GetMeetingById(Guid id)
        {
            var meeting = await _context.Meetings
                .AsNoTracking()
                .Include(m => m.Tags)
                .Include(m => m.User)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (meeting == null)
            {
                return Result.Failure<MeetingDTO>("not found");
            }

            var meetingDTO = _mapper.Map<MeetingDTO>(meeting);
            return Result.Success(meetingDTO);
        }



        public async Task<Result<List<MeetingDTO>>> GetMeetings()
        {
            var meetings = await _context.Meetings
                .AsNoTracking()
                .Include(m => m.Tags)
                .Include(m => m.User)
                    .ThenInclude(u => u.Tags)
                .ToListAsync();


            var meetingsDTO = meetings.Select(_mapper.Map<MeetingDTO>).ToList();
            return Result.Success(meetingsDTO);
        }



        public async Task<Result<List<MeetingDTO>>> GetMeetingsByUserId(Guid id)
        {
            var meetings = await _context.Meetings
                .AsNoTracking()
                .Where(m => m.UserId == id)
                .ToListAsync();


            var meetingsDTO = meetings.Select(_mapper.Map<MeetingDTO>).ToList();

            return Result.Success(meetingsDTO);
        }



        public async Task<Result<List<MeetingDTO>>> GetMeetingsToVisitByUserId(Guid id)
        {
            var meetings = await _context.Visits
                .AsNoTracking()
                .Where(v => v.UserId == id)
                .Include(v => v.Meeting)
                .Select(v => v.Meeting)
                .ToListAsync();


            var meetingsDTO = meetings.Select(_mapper.Map<MeetingDTO>).ToList();

            return Result.Success(meetingsDTO);
        }



        public async Task<Result> CreateMeeting(CreateMeetingRequest createMeetingRequest, Guid userId)
        {
            DateOnly date = DateOnly.Parse(createMeetingRequest.Date);
            TimeOnly timeStart = TimeOnly.Parse(createMeetingRequest.TimeStart);
            TimeOnly timeEnd = TimeOnly.Parse(createMeetingRequest.TimeEnd);



            var meetsCreatedCount = await _context.Meetings
                .CountAsync(m => m.UserId == userId && m.Deleted_At == null && m.Deleted_By == null);

            var userRating = _context.Users
                .AsNoTracking()
                .First(u => u.Id == userId)
                .Rating;

            var maximumMeetsToCreateCount = User.CanUserCreateMeeting(userRating);



            if (maximumMeetsToCreateCount > meetsCreatedCount)
            {
                var meeting = Meeting.CreateMeeting(userId, date, timeStart, timeEnd,
                    createMeetingRequest.Name, createMeetingRequest.Location,
                    createMeetingRequest.Description, createMeetingRequest.MaxGuest);

                List<MeetingsAndTags> meetingsAndTags = [];
                createMeetingRequest.TagIds.ForEach(t => meetingsAndTags.Add(new MeetingsAndTags()
                {
                    Created_At = DateTime.UtcNow,
                    Created_By = userId,
                    TagId = t,
                    MeetingId = meeting.Id
                }));

                await _context.MeetingsAndTags.AddRangeAsync(meetingsAndTags);
                await _context.Meetings.AddAsync(meeting);
                await _context.SaveChangesAsync();
                return Result.Success();
            }
            return Result.Failure("Meets to create limit is achieved");
        }


        
        public async Task<Result> EditMeeting(UpdateMeetingRequest updateMeetingRequest, Guid meetingId, Guid userId)
        {
            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                var rows = await _context.Meetings
                    .Where(u => u.Id == meetingId && u.UserId == userId)
                        .ExecuteUpdateAsync(u => u
                            .SetProperty(p => p.Name, p => string.IsNullOrEmpty(updateMeetingRequest.Name) ? p.Name : updateMeetingRequest.Name)
                            .SetProperty(p => p.Location, p => string.IsNullOrEmpty(updateMeetingRequest.Location) ? p.Location : updateMeetingRequest.Location)
                            .SetProperty(p => p.Date, p => string.IsNullOrEmpty(updateMeetingRequest.Date) ? p.Date : DateOnly.Parse(updateMeetingRequest.Date))
                            .SetProperty(p => p.TimeStart, p => string.IsNullOrEmpty(updateMeetingRequest.TimeStart) ? p.TimeStart : TimeOnly.Parse(updateMeetingRequest.TimeStart))
                            .SetProperty(p => p.TimeEnd, p => string.IsNullOrEmpty(updateMeetingRequest.TimeEnd) ? p.TimeEnd : TimeOnly.Parse(updateMeetingRequest.TimeEnd))
                            .SetProperty(p => p.MaxGuest, p => updateMeetingRequest.MaxGuest == null ? p.MaxGuest : updateMeetingRequest.MaxGuest)
                            .SetProperty(p => p.Description, p => string.IsNullOrEmpty(updateMeetingRequest.Description) ? p.Description : updateMeetingRequest.Description));

                if (updateMeetingRequest.TagIds != null)
                {
                    await _context.MeetingsAndTags
                        .Where(x => x.MeetingId == meetingId)
                        .ExecuteDeleteAsync();

                    List<MeetingsAndTags> meetingsAndTags = [];
                    meetingsAndTags.AddRange(updateMeetingRequest.TagIds.Select(x => new MeetingsAndTags()
                    {
                        Created_By = userId,
                        MeetingId = meetingId,
                        TagId = x
                    }));

                    await _context.MeetingsAndTags.AddRangeAsync(meetingsAndTags);
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch (TransactionAbortedException ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine("something went wrong");
                return Result.Failure("");
            }
            return Result.Success();
        }



        public async Task<Result> DeleteMeetingById(Guid id, Guid userId)
        {
            var row = await _context.Meetings
                .Where(m => m.Id == id && m.UserId == userId)
                    .ExecuteUpdateAsync(u => u
                        .SetProperty(p => p.Deleted_At, DateTime.UtcNow)
                        .SetProperty(p => p.Deleted_By, userId));

            if(row == 1)
                return Result.Success();

            return Result.Failure("");
        }



        public async Task<Result> RegisterUserOnMeeting(Guid meetingId, Guid userId)
        {
            return Result.Failure("");
        }



        //public async Task<Result> CancelUserRegistrationOnMeeting(Guid meetingId, Guid userId)
        //{
        //    var result = _visitService.CancelRegistration(meetingId, userId);

        //    //if (result.IsSuccess)
        //    //    return Result.Success();

        //    return Result.Failure("");
        //    //return Result.Failure(result.Error);
        //}


        
        public async Task<Result<List<MeetingDTO>>> FindMeetingsByParams(MeetingSearchRequest meetingSearchRequest)
        {
            IQueryable<Meeting> meetingsQuery = _context.Meetings;

            if(meetingSearchRequest.Name != null)
            {
                meetingsQuery = meetingsQuery.Where(m => m.Name.ToLower().Contains(meetingSearchRequest.Name.ToLower()));
            }
            if (meetingSearchRequest.Location != null)
            {
                meetingsQuery = meetingsQuery.Where(m => m.Location.ToLower().Contains(meetingSearchRequest.Location.ToLower()));
            }
            if (meetingSearchRequest.Date != null)
            {
                meetingsQuery = meetingsQuery.Where(m => m.Date >= DateOnly.Parse(meetingSearchRequest.Date));
            }
            if (meetingSearchRequest.TimeStart != null)
            {
                meetingsQuery = meetingsQuery.Where(m => m.TimeStart >= TimeOnly.Parse(meetingSearchRequest.TimeStart));
            }
            if (meetingSearchRequest.TimeEnd != null)
            {
                meetingsQuery = meetingsQuery.Where(m => m.TimeEnd >= TimeOnly.Parse(meetingSearchRequest.TimeEnd));
            }

            //pagination
            //

            List<Meeting> meetings = await meetingsQuery.ToListAsync();

            var meetingsDTO = meetings
                .Select(_mapper.Map<MeetingDTO>)
                .ToList();

            return Result.Success(meetingsDTO);
        }
    }
}