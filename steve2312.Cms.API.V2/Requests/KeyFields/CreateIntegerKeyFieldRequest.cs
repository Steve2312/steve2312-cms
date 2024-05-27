using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.API.V2.Requests.KeyFields;

public class CreateIntegerKeyFieldRequest
{
    public required string Key { get; init; }
}

public static class CreateIntegerKeyFieldRequestExtensions
{
    public static IntegerKeyField ToModel(this CreateIntegerKeyFieldRequest request)
    {
        return new IntegerKeyField
        {
            Key = request.Key
        };
    }
}