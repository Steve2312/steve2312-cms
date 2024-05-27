using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class DecimalValueField() : ValueField(FieldType.Decimal)
{
    public required decimal Value { get; set; }
    
    public virtual required DecimalKeyField? KeyField { get; set; }
}