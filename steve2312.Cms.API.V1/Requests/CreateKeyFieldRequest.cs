using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.KeyFields;

namespace steve2312.Cms.API.V1.Requests;

public class CreateKeyFieldRequest
{
    public required string Key { get; set; }
    public required FieldType Type { get; set; }
}

public static class CreateKeyFieldRequestExtensions
{
    public static KeyField ToModel(this CreateKeyFieldRequest createKeyFieldRequest)
    {
        return createKeyFieldRequest.Type switch
        {
            FieldType.Integer => new IntegerKeyField { Key = createKeyFieldRequest.Key },
            FieldType.Decimal => new DecimalKeyField { Key = createKeyFieldRequest.Key },
            FieldType.String => new StringKeyField { Key = createKeyFieldRequest.Key },
            FieldType.Double => new DoubleKeyField { Key = createKeyFieldRequest.Key },
            FieldType.Media => new MediaKeyField { Key = createKeyFieldRequest.Key },
            FieldType.Instance => new InstanceKeyField { Key = createKeyFieldRequest.Key },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}