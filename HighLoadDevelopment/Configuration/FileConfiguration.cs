using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = HighLoadDevelopment.Models.File;

namespace HighLoadDevelopment.Configuration
{
    public class FileConfiguration : IEntityTypeConfiguration<File>
    {
        public void Configure(EntityTypeBuilder<File> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(f => f.User)
                .WithOne(u => u.File);
        }
    }
}
