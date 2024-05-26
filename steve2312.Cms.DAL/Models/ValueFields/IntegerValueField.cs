using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class IntegerValueField() : ValueField(FieldType.Integer)
{
    public required int Value { get; set; }
    
    public virtual required IntegerKeyField? KeyField { get; set; }
}