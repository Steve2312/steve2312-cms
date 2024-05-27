using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Mappings.KeyFields;

public class KeyFieldConfiguration : IEntityTypeConfiguration<KeyField>
{
    public void Configure(EntityTypeBuilder<KeyField> builder)
    {
        builder
            .Property(field => field.Key)
            .HasMaxLength(30);
        
        // The key must be unique based on the model
        builder
            .HasIndex(field => new
            {
                field.Key,
                field.ModelId
            })
            .IsUnique();
    }
}