using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Responses;

public class ValueFieldResponse<T>
{
    public required Guid Id { get; init; }
    public required Guid KeyFieldId { get; init; }
    public required T Value { get; init; }
}

public static class ValueFieldResponseExtensions
{
    public static ValueFieldResponse<T> ToResponse<T>(this ValueField<T> valueField)
    {
        return new ValueFieldResponse<T>
        {
            Id = valueField.Id,
            KeyFieldId = valueField.KeyFieldId,
            Value = valueField.Value
        };
    }
}