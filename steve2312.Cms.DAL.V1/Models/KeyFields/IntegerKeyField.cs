using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class IntegerKeyField() : KeyField(FieldType.Integer)
{
    public virtual IList<IntegerValueField>? ValueFields { get; set; }
}