using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLoadDevelopment.Models
{
    public class Comment
    {
        public Comment()
        {
            
        }
        private Comment(Guid eventId, Guid userId, string text)
        {
            MeetingId = eventId;
            Id = Guid.NewGuid();
            UserId = userId;
            Created_At = DateTime.UtcNow;
            CommentText = text;
        }
        

        public Guid Id { get; set; }
        public Guid MeetingId { get; set; }
        public Guid UserId { get; set; }
        public string CommentText { get; set; }


        [ValidateNever]
        public Meeting? Meeting { get; set; }
        [ValidateNever]
        public User? User { get; set; }
        
        
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }



        public static Comment Create(Guid eventId, Guid userId, string text) => new(eventId, userId, text);
    }
}
