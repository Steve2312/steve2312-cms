using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Responses;

public class ModelResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required IEnumerable<KeyFieldResponse>? StringKeyFields { get; init; }
    public required IEnumerable<KeyFieldResponse>? IntegerKeyFields { get; init; }
}

public static class ModelResponseExtensions
{
    public static ModelResponse ToResponse(this Model model)
    {
        return new ModelResponse
        {
            Id = model.Id,
            Name = model.Name,
            StringKeyFields = model.StringKeyFields?.Select(KeyFieldResponseExtensions.ToResponse),
            IntegerKeyFields = model.IntegerKeyFields?.Select(KeyFieldResponseExtensions.ToResponse)
        };
    }
}