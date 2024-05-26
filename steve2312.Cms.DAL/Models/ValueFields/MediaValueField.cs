using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.KeyFields;

namespace steve2312.Cms.DAL.Models.ValueFields;

public class MediaValueField() : ValueField(FieldType.Media)
{
    public virtual required MediaKeyField? KeyField { get; set; }
}