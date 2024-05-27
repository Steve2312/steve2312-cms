using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class IntegerValueField() : ValueField(FieldType.Integer)
{
    public required int Value { get; set; }
    
    public virtual required IntegerKeyField? KeyField { get; set; }
}