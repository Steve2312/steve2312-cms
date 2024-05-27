using steve2312.Cms.API.V2.Requests.ValueFields;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateEntityRequest
{
    public required string Name { get; init; }
    public required IEnumerable<CreateStringValueFieldRequest> StringValueFields { get; init; }
    public required IEnumerable<CreateIntegerValueFieldRequest> IntegerValueFields { get; init; }
}

public static class CreateEntityRequestExtensions
{
    public static Entity ToModel(this CreateEntityRequest request, Model model)
    {
        return new Entity
        {
            Name = request.Name,
            Model = model,
            StringValueFields = request.StringValueFields.Select(CreateStringValueFieldRequestExtensions.ToModel).ToList(),
            IntegerValueFields = request.IntegerValueFields.Select(CreateIntegerValueFieldRequestExtensions.ToModel).ToList(),
        };
    }
}