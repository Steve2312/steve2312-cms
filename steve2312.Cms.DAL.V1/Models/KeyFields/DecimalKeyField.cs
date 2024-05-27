using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class DecimalKeyField() : KeyField(FieldType.Decimal)
{
    public virtual IList<DecimalValueField>? ValueFields { get; set; }
}