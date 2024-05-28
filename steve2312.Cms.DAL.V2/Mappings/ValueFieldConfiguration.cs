using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.DAL.V2.Mappings;

public class ValueFieldConfiguration : IEntityTypeConfiguration<ValueField>
{
    public void Configure(EntityTypeBuilder<ValueField> builder)
    {
        builder
            .HasIndex(field => new
            {
                field.KeyFieldId,
                field.EntityId
            })
            .IsUnique();
    }
}

public class ValueFieldConfiguration<T> : IEntityTypeConfiguration<ValueField<T>>
{
    public void Configure(EntityTypeBuilder<ValueField<T>> builder)
    {
        builder
            .HasOne(field => field.KeyField)
            .WithMany(field => field.ValueFields)
            .HasForeignKey(field => field.KeyFieldId)
            .IsRequired();
    }
}