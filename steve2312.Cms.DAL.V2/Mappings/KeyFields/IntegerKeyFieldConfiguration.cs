using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Mappings.KeyFields;

public class IntegerKeyFieldConfiguration : IEntityTypeConfiguration<IntegerKeyField>
{
    public void Configure(EntityTypeBuilder<IntegerKeyField> builder)
    {
        builder
            .HasOne(field => field.Model)
            .WithMany(model => model.IntegerKeyFields)
            .HasForeignKey(field => field.ModelId)
            .IsRequired();
    }
}