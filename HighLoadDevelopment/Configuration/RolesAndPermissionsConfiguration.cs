using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class RolesAndPermissionsConfiguration : IEntityTypeConfiguration<RolesAndPermissions>
    {
        public void Configure(EntityTypeBuilder<RolesAndPermissions> builder)
        {
            builder.HasKey(x => new { x.RoleId, x.PermissionId });

            builder.HasOne(x => x.Role).WithMany();
            builder.HasOne(x => x.Permission).WithMany();

            //builder.HasData(new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 1,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 2,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 3,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 4,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 5,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 6,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 7,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 8,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 9,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 10,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 11,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 12,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 13,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 14,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 15,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 16,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 17,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 18,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 19,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 20,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 1,
            //    PermissionId = 21,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //},

            //new RolesAndPermissions()
            //{
            //    RoleId = 2,
            //    PermissionId = 1,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 2,
            //    PermissionId = 4,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}, new RolesAndPermissions()
            //{
            //    RoleId = 2,
            //    PermissionId = 10,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //},


            //new RolesAndPermissions()
            //{
            //    RoleId = 3,
            //    PermissionId = 1,
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1
            //}
            //);
        }
    }
}
