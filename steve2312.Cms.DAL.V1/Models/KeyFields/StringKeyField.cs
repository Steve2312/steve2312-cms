using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class StringKeyField() : KeyField(FieldType.String)
{
    public virtual IList<StringValueField>? ValueFields { get; set; }
}