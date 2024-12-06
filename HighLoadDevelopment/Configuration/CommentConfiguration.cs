
using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using File = HighLoadDevelopment.Models.File;

namespace HighLoadDevelopment.Configuration
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id );

            builder.HasOne(f => f.User)
                .WithMany(u => u.Comments);

            builder.HasOne(f => f.Meeting)
                .WithMany(m => m.Comments);
        }
    }
}
