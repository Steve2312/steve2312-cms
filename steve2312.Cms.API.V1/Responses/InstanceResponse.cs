using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Responses;

public class InstanceResponse
{
    public required Guid Id { get; set; }
    public required DateTime Created { get; set; }
    public required DateTime Modified { get; set; }
    public required ModelResponse? Model { get; set; }
    public required IEnumerable<ValueFieldResponse>? ValueFields { get; set; }
}

public static class InstanceResponseExtensions
{
    public static InstanceResponse ToResponse(this Instance instance)
    {
        return new InstanceResponse
        {
            Id = instance.Id,
            Created = instance.Created,
            Modified = instance.Modified,
            Model = instance.Model?.ToResponse(),
            ValueFields = instance.ValueFields?.Select(ValueFieldResponseExtensions.ToResponse)
        };
    }
}