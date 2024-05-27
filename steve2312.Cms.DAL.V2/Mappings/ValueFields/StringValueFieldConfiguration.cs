using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Mappings.ValueFields;

public class StringValueFieldConfiguration : IEntityTypeConfiguration<StringValueField>
{
    public void Configure(EntityTypeBuilder<StringValueField> builder)
    {
        builder
            .Property(field => field.Value)
            .HasMaxLength(256);

        builder
            .HasOne(field => field.StringKeyField)
            .WithMany(field => field.StringValueFields)
            .HasForeignKey(field => field.KeyFieldId)
            .IsRequired();
        
        builder
            .HasOne(field => field.Entity)
            .WithMany(entity => entity.StringValueFields)
            .HasForeignKey(field => field.EntityId)
            .IsRequired();
    }
}