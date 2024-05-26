using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class InstanceValueField() : ValueField(FieldType.Instance)
{
    public virtual required IList<Guid>? Value { get; set; }
    public virtual required InstanceKeyField? KeyField { get; set; }
}