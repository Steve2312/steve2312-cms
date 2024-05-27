using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class InstanceValueField() : ValueField(FieldType.Instance)
{
    public virtual required IList<Guid>? Value { get; set; }
    public virtual required InstanceKeyField? KeyField { get; set; }
}