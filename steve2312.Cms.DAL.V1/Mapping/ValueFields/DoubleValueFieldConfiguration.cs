using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Mapping.ValueFields;

public class DoubleValueFieldConfiguration : IEntityTypeConfiguration<DoubleValueField>
{
    public void Configure(EntityTypeBuilder<DoubleValueField> builder)
    {
        builder
            .HasOne(d => d.KeyField)
            .WithMany(d => d.ValueFields);
    }
}