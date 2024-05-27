using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Mappings.ValueFields;

public class IntegerValueFieldConfiguration : IEntityTypeConfiguration<IntegerValueField>
{
    public void Configure(EntityTypeBuilder<IntegerValueField> builder)
    {
        builder
            .Property(field => field.Value)
            .HasMaxLength(256);

        builder
            .HasOne(field => field.IntegerKeyField)
            .WithMany(field => field.IntegerValueFields)
            .HasForeignKey(field => field.KeyFieldId)
            .IsRequired();
        
        builder
            .HasOne(field => field.Entity)
            .WithMany(entity => entity.IntegerValueFields)
            .HasForeignKey(field => field.EntityId)
            .IsRequired();
    }
}