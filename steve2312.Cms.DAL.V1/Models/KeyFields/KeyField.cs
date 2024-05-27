using steve2312.Cms.DAL.V1.Enums;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public abstract class KeyField(FieldType type)
{
    public Guid Id { get; set; }
    public required string Key { get; set; }
    public FieldType Type { get; private set; } = type;
    public DateTime Created { get; } = DateTime.Now;
    public DateTime Modified { get; } = DateTime.Now;
    
    public virtual Model? Model { get; set; }
}