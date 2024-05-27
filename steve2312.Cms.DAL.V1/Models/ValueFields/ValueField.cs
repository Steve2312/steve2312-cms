using steve2312.Cms.DAL.V1.Enums;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public abstract class ValueField(FieldType type)
{
    public Guid Id { get; set; }
    
    public FieldType Type { get; private set; } = type;

    public virtual required Instance? Instance { get; set; }
}