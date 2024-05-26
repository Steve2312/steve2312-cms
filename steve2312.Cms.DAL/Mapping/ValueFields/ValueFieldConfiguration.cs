using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Mapping.ValueFields;

public class ValueFieldConfiguration : IEntityTypeConfiguration<ValueField>
{
    public void Configure(EntityTypeBuilder<ValueField> builder)
    {
        builder
            .HasOne(v => v.Instance)
            .WithMany(i => i.ValueFields);
    }
}