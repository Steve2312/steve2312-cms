using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.API.V2.Responses;

public class IntegerKeyFieldResponse
{
    public required Guid Id { get; init; }
    public required string Key { get; init; }
}

public static class IntegerKeyFieldResponseExtensions
{
    public static IntegerKeyFieldResponse ToResponse(this IntegerKeyField keyField)
    {
        return new IntegerKeyFieldResponse
        {
            Id = keyField.Id,
            Key = keyField.Key
        };
    }
}