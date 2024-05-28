using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Requests;

public class CreateValueFieldRequest<T>
{
    public required T Value { get; set; }
    public required Guid KeyFieldId { get; set; }
}

public static class CreateValueFieldRequestExtensions
{
    public static ValueField<T> ToModel<T>(this CreateValueFieldRequest<T> request)
    {
        return new ValueField<T>
        {
            Value = request.Value,
            KeyFieldId = request.KeyFieldId
        };
    }
}