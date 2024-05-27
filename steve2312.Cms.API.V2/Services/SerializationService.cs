using System.Collections;
using System.Text.Json.Nodes;
using steve2312.Cms.DAL.V2.Models;
using steve2312.Cms.DAL.V2.Models.KeyFields;
using steve2312.Cms.DAL.V2.Models.ValueFields;

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

    private static IEnumerable<KeyValuePair<TK, TV?>> CombineKeyValueFields<TK, TV>(
        IEnumerable<TK> keyFields,
        IEnumerable<TV> valueFields
    ) 
        where TK: KeyField 
        where TV: ValueField
    {
        return (
            from keyField in keyFields
            join valueField in valueFields
                on keyField.Id equals valueField.KeyFieldId into field 
            from valueField in field.DefaultIfEmpty()
            select new KeyValuePair<TK, TV?>(keyField, valueField)
        );
    }
}