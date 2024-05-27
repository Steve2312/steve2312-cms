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
        
        // The model name must be unique
        builder
            .HasIndex(model => model.Name)
            .IsUnique();
        
        // Define relation with keyfields here
        builder
            .HasMany(model => model.DoubleKeyFields)
            .WithOne(field => field.Model)
            .HasForeignKey(field => field.ModelId);
    }
}