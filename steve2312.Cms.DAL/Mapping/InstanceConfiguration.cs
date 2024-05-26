using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using steve2312.Cms.DAL.Models;

namespace steve2312.Cms.DAL.Mapping;

public class InstanceConfiguration: IEntityTypeConfiguration<Instance>
{
    public void Configure(EntityTypeBuilder<Instance> builder)
    {
        builder
            .HasOne(i => i.Model)
            .WithMany(m => m.Instances);

        builder
            .HasMany(i => i.ValueFields)
            .WithOne(v => v.Instance);

        builder.Navigation(i => i.ValueFields).AutoInclude();
    }
}
