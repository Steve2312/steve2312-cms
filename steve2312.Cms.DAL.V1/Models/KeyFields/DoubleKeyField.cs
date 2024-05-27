using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class DoubleKeyField() : KeyField(FieldType.Double)
{ 
    public virtual IList<DoubleValueField>? ValueFields { get; set; }
}