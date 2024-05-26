using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class StringKeyField() : KeyField(FieldType.String)
{
    public virtual IList<StringValueField>? ValueFields { get; set; }
}