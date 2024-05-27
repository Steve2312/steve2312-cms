using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Models.ValueFields;

public class StringValueField : ValueField
{
    public required string Value { get; init; }
    
    public virtual StringKeyField? StringKeyField { get; init; }
}