using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace HighLoadDevelopment.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }


        [NotMapped]  
        [ValidateNever]
        [JsonIgnore]
        public List<User> Users { get; set; } = [];


        [NotMapped]  
        [ValidateNever]
        [JsonIgnore]
        public List<Meeting> Meetings { get; set; } = [];
    }
}
