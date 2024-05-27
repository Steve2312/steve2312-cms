using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class StringValueField() : ValueField(FieldType.String)
{
    public required string Value { get; set; }
    
    public virtual required StringKeyField? KeyField { get; set; }
}