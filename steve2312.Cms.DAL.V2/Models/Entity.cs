using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Models;

public class Entity
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    
    public virtual Model? Model { get; init; }
    public virtual ICollection<StringValueField>? StringValueFields { get; init; }
    public virtual ICollection<IntegerValueField>? IntegerValueFields { get; init; }
    
}