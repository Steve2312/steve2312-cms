using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.API.V2.Requests.ValueFields;

public class CreateStringValueFieldRequest
{
    public required string Value { get; set; }
    public required Guid KeyFieldId { get; set; }
}

public static class CreateStringValueFieldRequestExtensions
{
    public static StringValueField ToModel(this CreateStringValueFieldRequest request)
    {
        return new StringValueField
        {
            Value = request.Value,
            KeyFieldId = request.KeyFieldId
        };
    }
}