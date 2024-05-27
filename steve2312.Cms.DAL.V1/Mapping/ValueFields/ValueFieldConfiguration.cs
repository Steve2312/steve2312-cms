using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Mapping.ValueFields;

public class ValueFieldConfiguration : IEntityTypeConfiguration<ValueField>
{
    public void Configure(EntityTypeBuilder<ValueField> builder)
    {
        builder
            .HasOne(v => v.Instance)
            .WithMany(i => i.ValueFields);
    }
}