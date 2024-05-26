using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class DecimalValueField() : ValueField(FieldType.Decimal)
{
    public required decimal Value { get; set; }
    
    public virtual required DecimalKeyField? KeyField { get; set; }
}