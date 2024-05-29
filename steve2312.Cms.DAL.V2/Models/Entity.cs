namespace steve2312.Cms.DAL.V2.Models;

public class Entity
{
    public Guid Id { get; init; }
    public required string Name { get; init; }
    
    public virtual Model Model { get; init; } = null!;
    public virtual ICollection<ValueField<string>> StringValueFields { get; init; } = new List<ValueField<string>>();
    public virtual ICollection<ValueField<int>> IntegerValueFields { get; init; } = new List<ValueField<int>>();
    
}