using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.API.V2.Responses;

public class StringKeyFieldResponse
{
    public required Guid Id { get; init; }
    public required string Key { get; init; }
}

public static class StringKeyFieldResponseExtensions
{
    public static StringKeyFieldResponse ToResponse(this StringKeyField keyField)
    {
        return new StringKeyFieldResponse
        {
            Id = keyField.Id,
            Key = keyField.Key
        };
    }
}