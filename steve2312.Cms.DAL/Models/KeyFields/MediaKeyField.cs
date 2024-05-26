using steve2312.Cms.DAL.Enums;
using steve2312.Cms.DAL.Models.ValueFields;

namespace steve2312.Cms.DAL.Models.KeyFields;

public class MediaKeyField() : KeyField(FieldType.Media)
{
    public virtual IList<MediaValueField>? ValueFields { get; set; }
}