using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(u => u.Meetings)
                .WithOne(e => e.User);


            
            builder.HasMany(u => u.Visits)
                .WithOne(v => v.User);

            builder.HasMany(u => u.Tags)
                .WithMany(u => u.Users)
                .UsingEntity<UsersAndTags>();
            
            builder.HasMany(u => u.Roles)
                .WithMany(u => u.Users)
                .UsingEntity<UsersAndRoles>();

            builder.HasMany(u => u.Reports)
                .WithOne();

            builder.HasMany(u => u.Meetings)
                .WithOne(m => m.User);

            builder.HasOne(u => u.File)
                .WithOne(f => f.User);



            builder.HasIndex(u => u.Email)
                .IsUnique();

            builder.HasIndex(u => u.PhoneNumber)
                .IsUnique();
        }
    }
}
