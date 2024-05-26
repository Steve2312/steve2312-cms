using steve2312.Cms.DAL.Enums;

namespace steve2312.Cms.DAL.Models.KeyFields;

public abstract class KeyField(FieldType type)
{
    public Guid Id { get; set; }
    public required string Key { get; set; }
    public FieldType Type { get; private set; } = type;
    
    public virtual Model? Model { get; set; }
}