using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.DAL.V1.Models.KeyFields;

public class MediaKeyField() : KeyField(FieldType.Media)
{
    public virtual IList<MediaValueField>? ValueFields { get; set; }
}