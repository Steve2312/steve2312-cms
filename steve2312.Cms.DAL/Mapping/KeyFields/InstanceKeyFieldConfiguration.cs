using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Mapping.KeyFields;

public class InstanceKeyFieldConfiguration : IEntityTypeConfiguration<InstanceKeyField>
{
    public void Configure(EntityTypeBuilder<InstanceKeyField> builder)
    {
        builder
            .HasMany(d => d.ValueFields)
            .WithOne(d => d.KeyField);
    }
}