using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.DAL.V2.Mappings;

public class EntityConfiguration : IEntityTypeConfiguration<Entity>
{
    public void Configure(EntityTypeBuilder<Entity> builder)
    {
        builder
            .Property(entity => entity.Name)
            .HasMaxLength(30);

        builder
            .HasOne(entity => entity.Model)
            .WithMany(model => model.Entities)
            .IsRequired();
        
        builder
            .HasIndex(entity => entity.Name)
            .IsUnique();
        
        // Define relationships with ValueFields here!
        builder
            .HasMany(entity => entity.StringValueFields)
            .WithOne(field => field.Entity);
        
        builder
            .HasMany(entity => entity.IntegerValueFields)
            .WithOne(field => field.Entity);
    }
}