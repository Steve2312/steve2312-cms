using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public interface IEntityService
{
    Task<Entity> CreateWithModelIdAsync(CreateEntityRequest request, Guid modelId);
    Task<IEnumerable<Entity>?> GetAllByModelIdAsync(Guid id);
    Task<Entity?> GetAsync(Guid id);
}