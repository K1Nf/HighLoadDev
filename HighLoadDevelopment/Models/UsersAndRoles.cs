namespace HighLoadDevelopment.Models
{
    public class UsersAndRoles
    {
        public Guid UserId { get; set; }
        public int RoleId { get; set; }
        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }

        public User? User { get; set; }
        public Role? Role { get; set; }
    }
}
