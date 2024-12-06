using HighLoadDevelopment.Enums;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLoadDevelopment.Models
{
    public class Report
    {
        [Key]
        public Guid Id { get; init; }
        public Guid ReporterId { get; init; }
        public Guid ReportedId { get; init; }
        public ReportReasonStatus Reason { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime Deleted_At { get; set; }
        public Guid Deleted_By { get; set; }

        [NotMapped]
        [ValidateNever]
        [ForeignKey(nameof(ReporterId))]
        public User User { get; set; }
    }
}
