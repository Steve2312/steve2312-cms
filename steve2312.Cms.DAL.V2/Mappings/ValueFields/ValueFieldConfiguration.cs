using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Mappings.ValueFields;

public class ValueFieldConfiguration : IEntityTypeConfiguration<ValueField>
{
    public void Configure(EntityTypeBuilder<ValueField> builder)
    {
        // The value is unique based on the key it's referencing and it's instance 
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