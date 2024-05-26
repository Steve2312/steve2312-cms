using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Mapping.KeyFields;

public class StringKeyFieldConfiguration : IEntityTypeConfiguration<StringKeyField>
{
    public void Configure(EntityTypeBuilder<StringKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}