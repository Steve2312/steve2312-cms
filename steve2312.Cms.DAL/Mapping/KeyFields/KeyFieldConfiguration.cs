using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Mapping.KeyFields;

public class KeyFieldConfiguration: IEntityTypeConfiguration<KeyField>
{
    public void Configure(EntityTypeBuilder<KeyField> builder)
    {
        builder.Property(k => k.Key)
            .HasMaxLength(256);

        builder
            .HasOne(k => k.Model)
            .WithMany(m => m.KeyFields);
    }
}
