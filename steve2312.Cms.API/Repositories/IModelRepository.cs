using steve2312.Cms.API.Requests;
using steve2312.Cms.DAL.Models;

namespace steve2312.Cms.API.Repositories;

public interface IModelRepository
{
    Task<Model> CreateAsync(CreateModelRequest request);

    Task<Model?> GetAsync(Guid id);

    Task<IEnumerable<Model>> GetAllAsync();
}