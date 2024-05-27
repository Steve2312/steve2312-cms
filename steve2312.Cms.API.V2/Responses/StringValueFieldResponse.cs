using steve2312.Cms.DAL.V2.Models.ValueFields;

namespace steve2312.Cms.API.V2.Responses;

public class StringValueFieldResponse
{
    public required Guid Id { get; init; }
    public required Guid KeyFieldId { get; init; }
    public required string Value { get; init; }
}

public static class StringValueFieldResponseExtensions
{
    public static StringValueFieldResponse ToResponse(this StringValueField valueField)
    {
        return new StringValueFieldResponse
        {
            Id = valueField.Id,
            KeyFieldId = valueField.KeyFieldId,
            Value = valueField.Value
        };
    }
}