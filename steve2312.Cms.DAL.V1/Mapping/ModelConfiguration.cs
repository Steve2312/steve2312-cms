using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.DAL.V1.Mapping;

public class ModelConfiguration: IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder.Property(m => m.Name)
            .HasMaxLength(256);
        
        builder
            .HasMany(m => m.KeyFields)
            .WithOne(k => k.Model);

        builder
            .HasMany(m => m.Instances)
            .WithOne(i => i.Model);
    }
}