using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Repositories;

public interface IEntityRepository
{
    Task<IEnumerable<Entity>?> GetAllByModelIdAsync(Guid id);
    Task<Entity?> GetAsync(Guid id);
}