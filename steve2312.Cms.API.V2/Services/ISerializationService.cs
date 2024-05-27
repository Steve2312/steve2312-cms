using System.Text.Json.Nodes;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public interface ISerializationService
{
     JsonObject? Serialize(Entity entity);
}