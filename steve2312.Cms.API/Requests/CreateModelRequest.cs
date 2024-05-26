using steve2312.Cms.DAL.Models;

namespace steve2312.Cms.API.Requests;

public class CreateModelRequest
{
    public required string Name { get; set; }
    public required IList<CreateKeyFieldRequest> KeyFields { get; set; }
}

public static class CreateModelRequestExtensions
{
    public static Model ToModel(this CreateModelRequest createModelRequest)
    {
        return new Model
        {
            Name = createModelRequest.Name,
            KeyFields = createModelRequest.KeyFields.Select(CreateKeyFieldRequestExtensions.ToModel).ToList()
        };
    }
}