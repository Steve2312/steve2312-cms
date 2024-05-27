using steve2312.Cms.API.V1.Requests;
using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Repositories;

public interface IModelRepository
{
    Task<Model> CreateAsync(CreateModelRequest request);

    Task<Model?> GetAsync(Guid id);

    Task<IEnumerable<Model>> GetAllAsync();
}