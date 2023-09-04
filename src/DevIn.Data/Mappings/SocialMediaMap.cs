using DevIn.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIn.Data.Mappings
{
    public class SocialMediaMap : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Link)
                .IsRequired()
                .HasMaxLength(160);

            builder
                .HasOne(x => x.SocialMediaType)
                .WithMany(x => x.SocialMedia)
                .HasForeignKey("SocialMediaTypeId")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
