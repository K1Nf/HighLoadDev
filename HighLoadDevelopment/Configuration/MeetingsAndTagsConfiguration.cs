using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class MeetingsAndTagsConfiguration : IEntityTypeConfiguration<MeetingsAndTags>
    {
        public void Configure(EntityTypeBuilder<MeetingsAndTags> builder)
        {
            builder.HasKey(x => new { x.MeetingId, x.TagId });

            builder.HasOne(x => x.Meeting).WithMany();
            builder.HasOne(x => x.Tag).WithMany();
        }
    }
}
