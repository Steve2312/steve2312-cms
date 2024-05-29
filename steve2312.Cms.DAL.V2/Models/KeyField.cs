namespace steve2312.Cms.DAL.V2.Models;

public class KeyField
{
    public Guid Id { get; set; }
    public required string Key { get; init; }

    public required bool Required { get; init; }
    
    public Guid ModelId { get; init; }
    public virtual Model Model { get; init; } = null!;
}

public class KeyField<T> : KeyField
{
    public virtual ICollection<ValueField<T>> ValueFields { get; init; } = new List<ValueField<T>>();
}