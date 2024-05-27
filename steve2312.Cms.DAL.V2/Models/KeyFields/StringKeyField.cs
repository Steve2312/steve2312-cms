using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.DAL.V2.Models.KeyFields;

public class StringKeyField : KeyField
{
    public virtual ICollection<StringValueField>? StringValueFields { get; init; }
}