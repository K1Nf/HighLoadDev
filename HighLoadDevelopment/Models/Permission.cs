using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace HighLoadDevelopment.Models
{
    public class Permission
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
        public List<Role> Roles { get; set; } = [];
    }
}
