using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class MeetingConfiguration : IEntityTypeConfiguration<Meeting>
    {
        public void Configure(EntityTypeBuilder<Meeting> builder)
        {
            builder.HasKey(x => x.Id);


            builder.HasQueryFilter(m => m.Deleted_At == null);
        }
    }
}
