using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class DecimalKeyField() : KeyField(FieldType.Decimal)
{
    public virtual IList<DecimalValueField>? ValueFields { get; set; }
}