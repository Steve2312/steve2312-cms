using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class DoubleValueField() : ValueField(FieldType.Double)
{
    public required double Value { get; set; }
    
    public virtual required DoubleKeyField? KeyField { get; set; }
}