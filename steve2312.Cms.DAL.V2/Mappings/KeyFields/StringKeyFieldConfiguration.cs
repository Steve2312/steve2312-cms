using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Mappings.KeyFields;

public class StringKeyFieldConfiguration : IEntityTypeConfiguration<StringKeyField>
{
    public void Configure(EntityTypeBuilder<StringKeyField> builder)
    {
        builder
            .HasOne(field => field.Model)
            .WithMany(model => model.StringKeyFields)
            .HasForeignKey(field => field.ModelId)
            .IsRequired();
    }
}