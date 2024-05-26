using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class InstanceKeyField() : KeyField(FieldType.Instance)
{
    public virtual IList<InstanceValueField>? ValueFields { get; set; }
}