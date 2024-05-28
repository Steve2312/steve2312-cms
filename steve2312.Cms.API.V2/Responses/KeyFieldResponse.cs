using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Responses;

public class KeyFieldResponse
{
    public required Guid Id { get; init; }
    public required string Key { get; init; }
}

public static class KeyFieldResponseExtensions
{
    public static KeyFieldResponse ToResponse<T>(this KeyField<T> keyField)
    {
        return new KeyFieldResponse
        {
            Id = keyField.Id,
            Key = keyField.Key
        };
    }
}