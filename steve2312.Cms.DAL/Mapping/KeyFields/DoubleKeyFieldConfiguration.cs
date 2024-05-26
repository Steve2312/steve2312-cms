using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Mapping.KeyFields;

public class DoubleKeyFieldConfiguration : IEntityTypeConfiguration<DoubleKeyField>
{
    public void Configure(EntityTypeBuilder<DoubleKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}