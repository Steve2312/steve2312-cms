using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Mapping.ValueFields;

public class DecimalValueFieldConfiguration : IEntityTypeConfiguration<DecimalValueField>
{
    public void Configure(EntityTypeBuilder<DecimalValueField> builder)
    {
        builder
            .HasOne(d => d.KeyField)
            .WithMany(d => d.ValueFields);
    }
}