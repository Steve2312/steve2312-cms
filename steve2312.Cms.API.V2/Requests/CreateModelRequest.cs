using steve2312.Cms.API.V2.Requests.KeyFields;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateModelRequest
{
    public required string Name { get; init; }
    public required IEnumerable<CreateStringKeyFieldRequest> StringKeyFields { get; init; }
    public required IEnumerable<CreateIntegerKeyFieldRequest> IntegerKeyFields { get; init; }
}

public static class CreateModelRequestExtensions
{
    public static Model ToModel(this CreateModelRequest createModelRequest)
    {
        return new Model
        {
            Name = createModelRequest.Name,
            StringKeyFields = createModelRequest.StringKeyFields.Select(CreateStringKeyFieldRequestExtensions.ToModel).ToList(),
            IntegerKeyFields = createModelRequest.IntegerKeyFields.Select(CreateIntegerKeyFieldRequestExtensions.ToModel).ToList()
        };
    }
}