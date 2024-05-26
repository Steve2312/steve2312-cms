using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Mapping.ValueFields;

public class StringValueFieldConfiguration : IEntityTypeConfiguration<StringValueField>
{
    public void Configure(EntityTypeBuilder<StringValueField> builder)
    {
        builder.Property(s => s.Value)
            .HasMaxLength(512);
        
        builder
            .HasOne(d => d.KeyField)
            .WithMany(d => d.ValueFields);
    }
}