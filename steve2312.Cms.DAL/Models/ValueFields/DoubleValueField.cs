using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class DoubleValueField() : ValueField(FieldType.Double)
{
    public required double Value { get; set; }
    
    public virtual required DoubleKeyField? KeyField { get; set; }
}