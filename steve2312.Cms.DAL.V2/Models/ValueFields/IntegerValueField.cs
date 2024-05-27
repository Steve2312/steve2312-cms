using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.DAL.V2.Models.ValueFields;

public class IntegerValueField: ValueField
{
    public required int Value { get; init; }
    
    public virtual IntegerKeyField? IntegerKeyField { get; init; }
}