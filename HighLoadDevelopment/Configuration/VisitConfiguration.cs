using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class VisitConfiguration : IEntityTypeConfiguration<Visit>
    {
        public void Configure(EntityTypeBuilder<Visit> builder)
        {
            builder.HasKey(v => new { v.MeetingId, v.UserId });

            builder.HasOne(v => v.User)
                .WithMany(u => u.Visits);

            builder.HasOne(v => v.Meeting)
                .WithMany();
        }
    }
}
