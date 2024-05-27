using Microsoft.EntityFrameworkCore;
using steve2312.Cms.DAL.V2.Mappings;
using steve2312.Cms.DAL.V2.Mappings.KeyFields;
using steve2312.Cms.DAL.V2.Mappings.ValueFields;
using steve2312.Cms.DAL.V2.Models;
using steve2312.Cms.DAL.V2.Models.KeyFields;
using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2;

public class CmsDbContext(DbContextOptions options) : DbContext(options)
{
    public virtual DbSet<Model> Models { get; init; }
    public virtual DbSet<Entity> Entities { get; init; }
    public virtual DbSet<StringKeyField> StringKeyFields { get; init; }
    public virtual DbSet<StringValueField> StringValueFields { get; init; }
    
    public virtual DbSet<IntegerKeyField> IntegerKeyFields { get; init; }
    public virtual DbSet<IntegerValueField> IntegerValueFields { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ModelConfiguration());
        modelBuilder.ApplyConfiguration(new EntityConfiguration());
        
        modelBuilder.ApplyConfiguration(new KeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new StringKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new IntegerKeyFieldConfiguration());
        
        modelBuilder.ApplyConfiguration(new ValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new StringValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new IntegerValueFieldConfiguration());
    }
}