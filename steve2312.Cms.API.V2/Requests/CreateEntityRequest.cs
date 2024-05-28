using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateEntityRequest
{
    public required string Name { get; init; }
    public required IEnumerable<CreateValueFieldRequest<string>> StringValueFields { get; set; }
    public required IEnumerable<CreateValueFieldRequest<int>> IntegerValueFields { get; set; }
}

public static class CreateEntityRequestExtensions
{
    public static Entity ToModel(this CreateEntityRequest request, Model model)
    {
        request.StringValueFields = request.StringValueFields.FilterByKeyFields(model.StringKeyFields ?? []);
        request.IntegerValueFields = request.IntegerValueFields.FilterByKeyFields(model.IntegerKeyFields ?? []);

        return new Entity
        {
            Name = request.Name,
            Model = model,
            StringValueFields = request.StringValueFields.Select(CreateValueFieldRequestExtensions.ToModel).ToList(),
            IntegerValueFields = request.IntegerValueFields.Select(CreateValueFieldRequestExtensions.ToModel).ToList(),
        };
    }

    private static List<CreateValueFieldRequest<T>> FilterByKeyFields<T>(
        this IEnumerable<CreateValueFieldRequest<T>> valueFields,
        IEnumerable<KeyField<T>> keyFields
    )
    {
        return valueFields
            .Where(value => keyFields.FirstOrDefault(key => key.Id == value.KeyFieldId) != null)
            .ToList();
    }
}