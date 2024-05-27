using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.API.V1.Responses;

public class KeyFieldResponse
{
    public required Guid Id { get; set; }
    public required string Key { get; set; }
    public required FieldType Type { get; set; }
}

public static class KeyFieldResponseExtensions
{
    public static KeyFieldResponse ToResponse(this KeyField keyField)
    {
        return new KeyFieldResponse
        {
            Id = keyField.Id,
            Key = keyField.Key,
            Type = keyField.Type
        };
    }
}