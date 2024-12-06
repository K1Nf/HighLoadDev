namespace HighLoadDevelopment.Models
{
    public class RolesAndPermissions
    {
        public int RoleId { get; set; }
        public int PermissionId { get; set; }

        public DateTime Created_At { get; set; } = DateTime.UtcNow;
        public Guid Created_By { get; set; }
        public DateTime? Deleted_At { get; set; }
        public Guid? Deleted_By { get; set; }

        public Role? Role { get; set; } 
        public Permission? Permission { get; set; }
    }
}
