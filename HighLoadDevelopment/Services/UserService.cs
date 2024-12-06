using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HighLoadDevelopment.Models;
using HighLoadDevelopment.DataBaseContext;
using HighLoadDevelopment.Contracts.Requests;
using CSharpFunctionalExtensions;
using System.Transactions;
using HighLoadDevelopment.Contracts;
using Microsoft.AspNetCore.Mvc;
using HighLoadDevelopment.Contracts.DTO;

namespace HighLoadDevelopment.Services
{
    public class UserService(IMapper mapper,// IJwtProvider jwtProvider, 
       // IPasswordHash passwordHash, ICacheService cacheService, 
        AppDbContext context)
    {
        private readonly IMapper _mapper = mapper;
        //private readonly IJwtProvider _jwtProvider = jwtProvider;
        //private readonly IPasswordHash _passwordhash = passwordHash;
        //private readonly ICacheService _cacheService = cacheService;
        private readonly AppDbContext _context = context;

        public async Task<UserDTO?> GetUserById(Guid id)
        {
            var user = await _context.Users
                .AsNoTracking()
                .Include(u => u.Tags)
                .Include(u => u.Meetings)
                .FirstOrDefaultAsync(u => u.Id == id);

            var userDTO = _mapper.Map<UserDTO>(user);
            return userDTO;
        }



        public async Task<Result<List<UserDTO>>> GetUsers()
        {
            var users = await _context.Users
                .AsNoTracking()
                .ToListAsync();

            var usersDTO = users.Select(_mapper.Map<UserDTO>)
                .ToList();

            return Result.Success(usersDTO);
        }

        

        public async Task<Result> EditUser(UserUpdateRequest userUpdateRequest, Guid userId)
        {
            var transaction = await _context.Database.BeginTransactionAsync();

            try
            {
                await _context.Users
                    .Where(u => u.Id == userId)
                        .ExecuteUpdateAsync(u => u
                            .SetProperty(p => p.FirstName, p => userUpdateRequest.FirstName ==  null ?  p.FirstName : userUpdateRequest.FirstName)
                            .SetProperty(p => p.SecondName, p => userUpdateRequest.SecondName ==    null ?  p.SecondName : userUpdateRequest.SecondName)
                            .SetProperty(p => p.LastName, p => userUpdateRequest.LastName ==    null ?  p.LastName : userUpdateRequest.LastName)
                            .SetProperty(p => p.City, p => userUpdateRequest.City ==    null ?  p.City : userUpdateRequest.City)
                            .SetProperty(p => p.Information, p => userUpdateRequest.Information ==  null ?  p.Information : userUpdateRequest.Information)
                            .SetProperty(p => p.Email, p => userUpdateRequest.Email ==  null ?  p.Email : userUpdateRequest.Email)
                            .SetProperty(p => p.IsPrivate, p => userUpdateRequest.IsPrivate == null ?   p.IsPrivate : userUpdateRequest.IsPrivate));

                if(userUpdateRequest.TagIds!.Count != 0)
                {
                    await _context.UsersAndTags
                        .Where(x => x.UserId == userId)
                        .ExecuteDeleteAsync();

                    List<UsersAndTags> usersAndTags = [];
                    usersAndTags.AddRange(userUpdateRequest.TagIds.Select(x => new UsersAndTags()
                    {
                        Created_By = userId,
                        UserId = userId,
                        TagId = x
                    }));

                    await _context.UsersAndTags.AddRangeAsync(usersAndTags);
                }

                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
            catch(TransactionAbortedException ex)
            {
                await transaction.RollbackAsync();
                Console.WriteLine("something went wrong");
                return Result.Failure("something went wrong");
            }
            return Result.Success();
        }
        
        
        
        public async Task<Result<CheckMeetInfo>> CheckIfUserIsOwner(Guid meetId, Guid userId)
        {

            bool isUserAuthor = await _context.Meetings
                .CountAsync(m => m.UserId == userId && m.Id == meetId) == 1;

            bool isUserRegistrated = await _context.Visits
                .CountAsync(m => m.UserId == userId && m.MeetingId == meetId) == 1;

            bool isMeetRated = await _context.Visits
                .CountAsync(m => m.UserId == userId && m.MeetingId == meetId && m.Mark != null) == 1;

            CheckMeetInfo checkMeetInfo = new()
            {
                IsUserOwner = isUserAuthor,
                IsUserRegistrated = isUserRegistrated,
                IsMeetRated = isMeetRated
            };

            return Result.Success(checkMeetInfo);
        }



        // вернет failure только если юзер не найден,
        // true - если оценка сейчас была проставлена, false - если оценка уже до вызова метода была проставлена
        //public async Task<Result> MakeMarkToUser(int mark, Guid userId, Guid eventId, Guid tokenId) 
        //{
        //    var user = await GetUserById(userId);
        //    if (user == null)
        //    {
        //        return Result.Failure("User doesn't exist");
        //    }

        //    var newRating = user.ChangeRating(mark);

        //    return await _userRepository.GiveRateTransaction(newRating, mark, userId, eventId, tokenId);
        //}



        



        //public async Task<List<EventResponse>> GetGhostedEvents(Guid userId)
        //{
        //    var visits = await _visitRepository.GetVisitByUserId(userId);


        //    if (visits.Count != 0)
        //    {
        //        var events = visits.Select(v => v.Event).ToList();
        //        var eventRespones = new List<EventResponse>();
        //        foreach (var eve in events)
        //        {
        //            //Event.ChangeStatus(eve);
        //            var eventRespone = _mapper.Map<EventResponse>(eve);
        //            eventRespones.Add(eventRespone);
        //        }
        //        return eventRespones;
        //    }
        //    return [];
        //}
    }
}