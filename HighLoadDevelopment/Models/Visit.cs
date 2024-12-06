using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLoadDevelopment.Models
{
    public class Visit
    {
        public Visit()
        {
            
        }
        private Visit(Guid eventId, Guid userId)
        {
            MeetingId = eventId;
            UserId = userId;
            Created_At = DateTime.UtcNow;
        }
        

        public Guid MeetingId { get; set; }
        public Guid UserId { get; set; }
        public int? Mark { get; set; }


        [ValidateNever]
        public Meeting? Meeting { get; set; }
        [ValidateNever]
        //[ForeignKey(nameof(UserId))]
        public User? User { get; set; }
        
        
        public DateTime? Marked_At { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }



        public static Visit Create(Guid eventId, Guid userId) => new(eventId, userId);
    }
}
