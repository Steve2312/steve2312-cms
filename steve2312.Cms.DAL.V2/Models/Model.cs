using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Models;

public class Model
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    public virtual ICollection<StringKeyField>? StringKeyFields { get; init; }
    public virtual ICollection<IntegerKeyField>? IntegerKeyFields { get; init; }
    
    public virtual ICollection<KeyField<double>>? DoubleKeyFields { get; init;  }
    public virtual ICollection<Entity>? Entities { get; init; }
}