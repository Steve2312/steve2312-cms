using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.DAL.V1.Models.ValueFields;

public class MediaValueField() : ValueField(FieldType.Media)
{
    public virtual required MediaKeyField? KeyField { get; set; }
}