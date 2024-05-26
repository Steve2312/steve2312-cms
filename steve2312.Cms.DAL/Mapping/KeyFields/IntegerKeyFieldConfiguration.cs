using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Mapping.KeyFields;

public class IntegerKeyFieldConfiguration : IEntityTypeConfiguration<IntegerKeyField>
{
    public void Configure(EntityTypeBuilder<IntegerKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}