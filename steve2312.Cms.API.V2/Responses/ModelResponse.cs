using steve2312.Cms.DAL.V2.Models;
using steve2312.Cms.DAL.V2.Models.KeyFields;

namespace steve2312.Cms.API.V2.Responses;

public class ModelResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required IEnumerable<StringKeyFieldResponse>? StringKeyFields { get; init; }
    public required IEnumerable<IntegerKeyFieldResponse>? IntegerKeyFields { get; init; }
}

public static class ModelResponseExtensions
{
    public static ModelResponse ToResponse(this Model model)
    {
        return new ModelResponse
        {
            Id = model.Id,
            Name = model.Name,
            StringKeyFields = model.StringKeyFields?.Select(StringKeyFieldResponseExtensions.ToResponse),
            IntegerKeyFields = model.IntegerKeyFields?.Select(IntegerKeyFieldResponseExtensions.ToResponse)
        };
    }
}