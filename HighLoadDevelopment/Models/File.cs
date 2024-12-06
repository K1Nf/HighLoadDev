using HighLoadDevelopment.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HighLoadDevelopment.Models
{
    public class File
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public string Format { get; set; } = string.Empty;
        public string Size { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Deleted_By { get; set; }
        public DateTime Deleted_At { get; set; }


        [ForeignKey(nameof(UserId))]
        public User? User { get; set; }
    }
}
