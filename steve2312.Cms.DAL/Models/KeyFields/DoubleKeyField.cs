using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class DoubleKeyField() : KeyField(FieldType.Double)
{ 
    public virtual IList<DoubleValueField>? ValueFields { get; set; }
}