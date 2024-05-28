using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateKeyFieldRequest
{
    public required string Key { get; init; }
}

public static class CreateKeyFieldRequestExtensions
{
    public static KeyField<T> ToModel<T>(this CreateKeyFieldRequest request)
    {
        return new KeyField<T>
        {
            Key = request.Key
        };
    }
}