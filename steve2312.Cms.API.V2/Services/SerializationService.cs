using System.Text.Json.Nodes;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public class SerializationService : ISerializationService
{
    public JsonObject? Serialize(Entity entity)
    {
        var json = new JsonObject();

        var stringKeyFields = entity.Model?.StringKeyFields;
        var integerKeyFields = entity.Model?.IntegerKeyFields;
        
        if (stringKeyFields == null || integerKeyFields == null) return null;
        
        var stringValueFields = entity.StringValueFields ?? [];
        var integerValueFields = entity.IntegerValueFields ?? [];

        var stringPairs = CombineKeyValueFields(stringKeyFields, stringValueFields);
        var integerPairs = CombineKeyValueFields(integerKeyFields, integerValueFields);
        
        foreach (var pair in stringPairs)
        {
            json.Add(pair.Key.Key, pair.Value?.Value);
        }
        
        foreach (var pair in integerPairs)
        {
            json.Add(pair.Key.Key, pair.Value?.Value);
        }

        return json;
    }

    private static IEnumerable<KeyValuePair<KeyField<T>, ValueField<T>?>> CombineKeyValueFields<T>(
        IEnumerable<KeyField<T>> keyFields,
        IEnumerable<ValueField<T>> valueFields
    ) 
    {
        return (
            from keyField in keyFields
            join valueField in valueFields
                on keyField.Id equals valueField.KeyFieldId into field 
            from valueField in field.DefaultIfEmpty()
            select new KeyValuePair<KeyField<T>, ValueField<T>?>(keyField, valueField)
        );
    }
}