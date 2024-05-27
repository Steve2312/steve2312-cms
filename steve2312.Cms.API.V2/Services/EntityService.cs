using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public class EntityService(IEntityRepository repository) : IEntityService
{
    public Task<IEnumerable<Entity>?> GetAllByModelIdAsync(Guid id)
    {
        return repository.GetAllByModelIdAsync(id);
    }

    public Task<Entity?> GetAsync(Guid id)
    {
        return repository.GetAsync(id);
    }
}