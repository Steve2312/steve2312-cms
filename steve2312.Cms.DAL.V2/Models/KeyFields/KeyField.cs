using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Models.KeyFields;

public class KeyField
{
    public Guid Id { get; set; }
    public required string Key { get; init; }
    
    public Guid ModelId { get; init; }
    public virtual Model? Model { get; init; }
}

public class KeyField<T> : KeyField
{
    public virtual ICollection<ValueField<T>>? ValueFields { get; init; }
}