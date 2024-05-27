using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.API.V2.Requests.ValueFields;

public class CreateIntegerValueFieldRequest
{
    public required int Value { get; set; }
    public required Guid KeyFieldId { get; set; }
}

public static class CreateIntegerValueFieldRequestExtensions
{
    public static IntegerValueField ToModel(this CreateIntegerValueFieldRequest request)
    {
        return new IntegerValueField
        {
            Value = request.Value,
            KeyFieldId = request.KeyFieldId
        };
    }
}