using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateModelRequest
{
    public required string Name { get; init; }
    public required IEnumerable<CreateKeyFieldRequest> StringKeyFields { get; init; }
    public required IEnumerable<CreateKeyFieldRequest> IntegerKeyFields { get; init; }
}

public static class CreateModelRequestExtensions
{
    public static Model ToModel(this CreateModelRequest createModelRequest)
    {
        return new Model
        {
            Name = createModelRequest.Name,
            StringKeyFields = createModelRequest.StringKeyFields.Select(CreateKeyFieldRequestExtensions.ToModel<string>).ToList(),
            IntegerKeyFields = createModelRequest.IntegerKeyFields.Select(CreateKeyFieldRequestExtensions.ToModel<int>).ToList()
        };
    }
}