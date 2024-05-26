using Microsoft.EntityFrameworkCore;
using steve2312.Cms.DAL.Mapping;
using steve2312.Cms.DAL.Mapping.KeyFields;
using steve2312.Cms.DAL.Mapping.ValueFields;
using steve2312.Cms.DAL.Models;
using steve2312.Cms.DAL.Models.KeyFields;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL;

public class CmsDbContext(DbContextOptions options) : DbContext(options)
{
    public virtual DbSet<Model> Models { get; init; }
    public virtual DbSet<Instance> Instances { get; init; }
    
    public virtual DbSet<DecimalKeyField> DecimalKeyFields { get; init; }
    public virtual DbSet<DoubleKeyField> DoubleKeyFields { get; init; }
    public virtual DbSet<InstanceKeyField> InstanceKeyFields { get; init; }
    public virtual DbSet<IntegerKeyField> IntegerKeyFields { get; init; }
    public virtual DbSet<MediaKeyField> MediaKeyFields { get; init; }
    public virtual DbSet<StringKeyField> StringKeyFields { get; init; }
    
    public virtual DbSet<DecimalValueField> DecimalValueFields { get; init; }
    public virtual DbSet<DoubleValueField> DoubleValueFields { get; init; }
    public virtual DbSet<InstanceValueField> InstanceValueFields { get; init; }
    public virtual DbSet<IntegerValueField> IntegerValueFields { get; init; }
    public virtual DbSet<MediaValueField> MediaValueFields { get; init; }
    public virtual DbSet<StringValueField> StringValueFields { get; init; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ModelConfiguration());
        modelBuilder.ApplyConfiguration(new InstanceConfiguration());
        
        modelBuilder.ApplyConfiguration(new KeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new DecimalKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new DoubleKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new InstanceKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new IntegerKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new MediaKeyFieldConfiguration());
        modelBuilder.ApplyConfiguration(new StringKeyFieldConfiguration());
        
        modelBuilder.ApplyConfiguration(new ValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new DecimalValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new DoubleValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new InstanceValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new IntegerValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new MediaValueFieldConfiguration());
        modelBuilder.ApplyConfiguration(new StringValueFieldConfiguration());
    }
}