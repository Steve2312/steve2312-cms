using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Responses;

public class EntityResponse
{
    public required Guid Id { get; init; }
    public required string Name { get; init; }
    public required ModelResponse? Model { get; init; }
    public required IEnumerable<StringValueFieldResponse>? StringValueFields { get; init; }
}

public static class EntityResponseExtensions
{
    public static EntityResponse ToResponse(this Entity entity)
    {
        return new EntityResponse
        {
            Id = entity.Id,
            Name = entity.Name,
            Model = entity.Model?.ToResponse(),
            StringValueFields = entity.StringValueFields?.Select(StringValueFieldResponseExtensions.ToResponse)
        };
    }
}