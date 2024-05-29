using System.Text.Json.Nodes;
using steve2312.Cms.API.V2.Extensions;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public class SerializationService : ISerializationService
{
    public JsonObject? Serialize(Entity entity)
    {
        var json = new JsonObject();

        entity.Model.StringKeyFields
            .MapValueFields(entity.StringValueFields)
            .ToList()
            .ForEach(pair =>
            {
                json.Add(pair.Key.Key, pair.Value?.Value);
            });
        
        entity.Model.IntegerKeyFields
            .MapValueFields(entity.IntegerValueFields)
            .ToList()
            .ForEach(pair =>
            {
                json.Add(pair.Key.Key, pair.Value?.Value);
            });

        return json;
    }
}