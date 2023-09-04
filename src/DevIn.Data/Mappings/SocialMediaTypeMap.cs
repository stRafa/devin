using DevIn.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIn.Data.Mappings
{
    public class SocialMediaTypeMap : IEntityTypeConfiguration<SocialMediaType>
    {
        public void Configure(EntityTypeBuilder<SocialMediaType> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(x => x.Slug)
                .IsRequired()
                .HasMaxLength(40);
        }
    }
}
