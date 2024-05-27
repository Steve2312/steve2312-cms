using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Responses;

public class ModelResponse
{
    public required Guid Id { get; set; }
    public required string Name { get; set; }
    public required IEnumerable<KeyFieldResponse>? KeyFields { get; set; }
}

public static class ModelResponseExtensions
{
    public static ModelResponse ToResponse(this Model model)
    {
        return new ModelResponse
        {
            Id = model.Id,
            Name = model.Name,
            KeyFields = model.KeyFields?.Select(keyField => keyField.ToResponse())
        };
    }
}