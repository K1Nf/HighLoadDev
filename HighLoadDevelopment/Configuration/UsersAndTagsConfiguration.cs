using HighLoadDevelopment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HighLoadDevelopment.Configuration
{
    public class UsersAndTagsConfiguration : IEntityTypeConfiguration<UsersAndTags>
    {
        public void Configure(EntityTypeBuilder<UsersAndTags> builder)
        {
            builder.HasKey(x => new { x.UserId, x.TagId });

            builder.HasOne(x => x.User)
                .WithMany();

            builder.HasOne(x => x.Tag)
                .WithMany();
        }
    }
}
