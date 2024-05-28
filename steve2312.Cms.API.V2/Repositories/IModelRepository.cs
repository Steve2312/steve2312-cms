using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Repositories;

public interface IModelRepository
{
    Task<Model> CreateAsync(Model model);
    Task<Model?> GetAsync(Guid id);
    Task<IEnumerable<Model>> GetAllAsync();
}