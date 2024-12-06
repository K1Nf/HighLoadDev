using HighLoadDevelopment.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HighLoadDevelopment.Contracts
{
    public class VisitDTO
    {
        public Guid EventId { get; set; }
        public Guid UserId { get; set; }
        public int? Mark { get; set; }


        [ValidateNever]
        public Meeting? Event { get; set; }
        [ValidateNever]
        public User? User { get; set; }


        public DateTime? Marked_At { get; set; }
    }
}
