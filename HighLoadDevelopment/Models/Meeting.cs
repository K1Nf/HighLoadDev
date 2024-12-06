using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using HighLoadDevelopment.Enums;
using System.Text.Json.Serialization;

namespace HighLoadDevelopment.Models
{
    public class Meeting
    {
        public Meeting() { }

        private Meeting(string _name, string _place, DateOnly _date, TimeOnly _timestart, TimeOnly _timeend, 
                        int _maxGuests, string _description, Guid _userId)
        {
            Id = Guid.NewGuid();
            Name = _name;
            Location = _place;
            Date = _date;
            TimeStart = _timestart;
            TimeEnd = _timeend;
            MaxGuest = _maxGuests;
            Description = _description;
            Created_At = DateTime.UtcNow;
            Status = EventStatus.Planned;
            UserId = _userId;
        }



        [Key]
        public Guid Id { get; init; }
        public string Name { get; set; }
        public string Location { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public int MaxGuest { get; set; }
        public int CurrentGuestsCount { get; set; } = 0;
        public EventStatus Status { get; set; } = EventStatus.Planned;
        public string? Description { get; set; } = string.Empty;

        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid UserId { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }


        [ValidateNever]
        [NotMapped]
        public User User { get; set; }
        
        [NotMapped]
        public List<Tag> Tags { get; set; } = [];

        [NotMapped]
        public List<Visit> Visits { get; set; } = []; 
        
        [JsonIgnore]
        public List<Comment> Comments { get; set; } = [];

        [NotMapped]
        public List<int> TagsIds { get; set; } = [];



        public static Meeting CreateMeeting(Guid userId, DateOnly date, TimeOnly timeStart, 
            TimeOnly timeEnd, string name, string place, string description, int maxGuests)
            => 
            new (name, place, date, timeStart, timeEnd, maxGuests, description, userId);



        public static void ChangeStatus(Meeting ev)
        {
            var date = ev.Date.CompareTo(DateOnly.FromDateTime(DateTime.Today));
            var timeStart = ev.TimeStart.CompareTo(TimeOnly.FromDateTime(DateTime.Now));
            var timeEnd = ev.TimeEnd.CompareTo(TimeOnly.FromDateTime(DateTime.Now));


            if (date == 0)
            {
                // сравниваем время
                if(timeStart == -1) // евент начался
                {
                    ev.Status = timeEnd == 1 ? EventStatus.InProgress : EventStatus.Completed;
                }
            }
            else if (date == -1)
            {
                ev.Status = EventStatus.Completed;
            }
        }
    }
}
