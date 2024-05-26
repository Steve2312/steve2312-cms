using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class IntegerKeyField() : KeyField(FieldType.Integer)
{
    public virtual IList<IntegerValueField>? ValueFields { get; set; }
}