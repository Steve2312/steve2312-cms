using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.DAL.V2.Mappings;

public class ModelConfiguration : IEntityTypeConfiguration<Model>
{
    public void Configure(EntityTypeBuilder<Model> builder)
    {
        builder
            .Property(model => model.Name)
            .HasMaxLength(30);

        builder
            .HasIndex(model => model.Name)
            .IsUnique();
        
        builder
            .HasIndex(model => model.Name)
            .IsUnique();
        
        builder
            .HasMany(model => model.StringKeyFields)
            .WithOne(field => field.Model)
            .HasForeignKey(field => field.ModelId)
            .IsRequired();
        
        builder
            .HasMany(model => model.IntegerKeyFields)
            .WithOne(field => field.Model)
            .HasForeignKey(field => field.ModelId)
            .IsRequired();
    }
}