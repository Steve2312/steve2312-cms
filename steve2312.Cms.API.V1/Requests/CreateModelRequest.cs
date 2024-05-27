using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Requests;

public class CreateModelRequest
{
    public required string Name { get; set; }
}

public static class CreateModelRequestExtensions
{
    public static Model ToModel(this CreateModelRequest createModelRequest)
    {
        return new Model
        {
            Name = createModelRequest.Name
        };
    }
}