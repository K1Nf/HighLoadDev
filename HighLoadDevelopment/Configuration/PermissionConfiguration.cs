using HighLoadDevelopment.Extensions;
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(p => p.Roles)
                .WithMany(r => r.Permissions)
                .UsingEntity<RolesAndPermissions>();

            //builder.HasData(PermissionsSeed.GetPermissions());
        }
    }
}
