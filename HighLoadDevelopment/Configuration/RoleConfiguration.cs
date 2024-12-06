using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(r => r.Permissions)
                .WithMany(r => r.Roles)
                .UsingEntity<RolesAndPermissions>();

            builder.HasMany(r => r.Users)
                .WithMany(r => r.Roles)
                .UsingEntity<UsersAndRoles>();

            //builder.HasData(new Role()
            //{
            //    Id = 1,
            //    Name = "Admin",
            //    Code = "Admin",
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1,

            //}, new Role()
            //{
            //    Id = 2,
            //    Name = "User",
            //    Code = "User",
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1,
            //},
            //new Role()
            //{
            //    Id = 3,
            //    Name = "Guest",
            //    Code = "Guest",
            //    Created_At = DateTime.UtcNow,
            //    //Created_By = 1,
            //});
        }
    }
}
