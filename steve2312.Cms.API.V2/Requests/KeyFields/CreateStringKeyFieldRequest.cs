using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.API.V2.Requests.KeyFields;

public class CreateStringKeyFieldRequest
{
    public required string Key { get; init; }
}

public static class CreateStringKeyFieldRequestExtensions
{
    public static StringKeyField ToModel(this CreateStringKeyFieldRequest request)
    {
        return new StringKeyField
        {
            Key = request.Key
        };
    }
}