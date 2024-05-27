using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.API.V2.Responses;

public class IntegerValueFieldResponse
{
    public required Guid Id { get; init; }
    public required Guid KeyFieldId { get; init; }
    public required int Value { get; init; }
}

public static class IntegerValueFieldResponseExtensions
{
    public static IntegerValueFieldResponse ToResponse(this IntegerValueField valueField)
    {
        return new IntegerValueFieldResponse
        {
            Id = valueField.Id,
            KeyFieldId = valueField.KeyFieldId,
            Value = valueField.Value
        };
    }
}