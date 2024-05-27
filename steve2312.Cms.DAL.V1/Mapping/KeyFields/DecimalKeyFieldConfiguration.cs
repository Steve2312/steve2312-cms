using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Mapping.KeyFields;

public class DecimalKeyFieldConfiguration : IEntityTypeConfiguration<DecimalKeyField>
{
    public void Configure(EntityTypeBuilder<DecimalKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}