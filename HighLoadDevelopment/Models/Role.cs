using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HighLoadDevelopment.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; } = string.Empty;
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }

        [JsonIgnore]
        public List<User> Users { get; set; } = [];

        public List<Permission> Permissions {  get; set; } = [];
    }
}
