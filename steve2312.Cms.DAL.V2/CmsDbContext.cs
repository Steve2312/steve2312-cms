using Microsoft.EntityFrameworkCore;
using steve2312.Cms.DAL.V2.Mappings;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.DAL.V2;

public class CmsDbContext(DbContextOptions options) : DbContext(options)
{
    public virtual DbSet<Model> Models { get; init; }
    public virtual DbSet<Entity> Entities { get; init; }
    public virtual DbSet<KeyField<string>> StringKeyFields { get; init; }
    public virtual DbSet<ValueField<string>> StringValueFields { get; init; }
    public virtual DbSet<KeyField<int>> IntegerKeyFields { get; init; }
    public virtual DbSet<ValueField<int>> IntegerValueFields { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ModelConfiguration());
        modelBuilder.ApplyConfiguration(new EntityConfiguration());
        modelBuilder.ApplyConfiguration(new KeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new ValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new ValueFieldConfiguration<string>());
        modelBuilder.ApplyConfiguration(new ValueFieldConfiguration<int>());
    }
}