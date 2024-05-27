using steve2312.Cms.DAL.V1.Enums;
using steve2312.Cms.DAL.V1.Models.ValueFields;

namespace steve2312.Cms.API.V1.Responses;

public class ValueFieldResponse
{
    public required Guid Id { get; set; }
    public required FieldType Type { get; set; }
    
    public required KeyFieldResponse? KeyField { get; set; }
    public int? Integer { get; set; }
    public decimal? Decimal { get; set; }
    public string? String { get; set; }
    public double? Double { get; set; }
    public MediaResponse? Media { get; set; }
    public IEnumerable<Guid>? Instances { get; set; }
}

public static class ValueFieldResponseExtensions
{
    public static ValueFieldResponse ToResponse(this ValueField valueField)
    {
        return valueField switch
        {
            IntegerValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), Integer = field.Value
            },
            DecimalValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), Decimal = field.Value
            },
            StringValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), String = field.Value
            },            
            DoubleValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), Double = field.Value
            },
            MediaValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), Media = new MediaResponse()
            },
            InstanceValueField field => new ValueFieldResponse
            {
                Id = field.Id, Type = field.Type, KeyField = field.KeyField?.ToResponse(), Instances = field.Value
            },
            _ => throw new ArgumentOutOfRangeException()
        };
    }
}