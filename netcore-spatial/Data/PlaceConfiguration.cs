using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace netcore_spatial.Data
{
    public class PlaceConfiguration : IEntityTypeConfiguration<Place>
    {
        public void Configure(EntityTypeBuilder<Place> entity)
        {
            entity.ToTable("place");
            entity.Property(x => x.Id).HasDefaultValueSql("uuid_generate_v4()").HasColumnName("id");
            entity.Property(x => x.Name).IsRequired().HasMaxLength(200).HasColumnName("name");
            entity.Property(x => x.Point).IsRequired().HasColumnType("geography (point)").HasColumnName("point");
        }
    }
}