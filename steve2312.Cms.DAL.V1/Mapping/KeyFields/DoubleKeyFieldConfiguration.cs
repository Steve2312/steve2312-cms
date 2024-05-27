using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Mapping.KeyFields;

public class DoubleKeyFieldConfiguration : IEntityTypeConfiguration<DoubleKeyField>
{
    public void Configure(EntityTypeBuilder<DoubleKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}