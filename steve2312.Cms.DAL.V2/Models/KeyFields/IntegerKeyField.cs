using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Models.KeyFields;

public class IntegerKeyField: KeyField
{
    public virtual ICollection<IntegerValueField>? IntegerValueFields { get; init; }

}