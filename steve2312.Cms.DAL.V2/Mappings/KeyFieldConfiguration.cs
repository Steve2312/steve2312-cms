using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.DAL.V2.Mappings;

public class KeyFieldConfiguration : IEntityTypeConfiguration<KeyField>
{
    public void Configure(EntityTypeBuilder<KeyField>builder)
    {
        builder
            .Property(field => field.Key)
            .HasMaxLength(30);
        
        builder
            .HasIndex(field => new
            {
                field.Key,
                field.ModelId
            })
            .IsUnique();
    }
}