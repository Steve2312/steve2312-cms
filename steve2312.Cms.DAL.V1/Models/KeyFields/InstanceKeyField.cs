using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class InstanceKeyField() : KeyField(FieldType.Instance)
{
    public virtual IList<InstanceValueField>? ValueFields { get; set; }
}