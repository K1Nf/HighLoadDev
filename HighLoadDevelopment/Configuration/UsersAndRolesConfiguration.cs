using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class UsersAndRolesConfiguration : IEntityTypeConfiguration<UsersAndRoles>
    {
        public void Configure(EntityTypeBuilder<UsersAndRoles> builder)
        {
            builder.HasKey(x => new { x.UserId, x.RoleId });

            builder.HasOne(x => x.User)
                .WithMany();
            
            builder.HasOne(x => x.Role)
                .WithMany();
        }
    }
}
