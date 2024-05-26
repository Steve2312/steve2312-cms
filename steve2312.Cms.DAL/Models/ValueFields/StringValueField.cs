using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class StringValueField() : ValueField(FieldType.String)
{
    public required string Value { get; set; }
    
    public virtual required StringKeyField? KeyField { get; set; }
}