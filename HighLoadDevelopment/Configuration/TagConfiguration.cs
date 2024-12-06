using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(r => r.Users)
                .WithMany(t => t.Tags)
                .UsingEntity<UsersAndTags>();

            builder.HasMany(r => r.Meetings)
                .WithMany(m => m.Tags)
                .UsingEntity<MeetingsAndTags>();
        }
    }
}
