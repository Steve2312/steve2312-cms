using steve2312.Cms.API.V1.Repositories;
using steve2312.Cms.API.V1.Requests;
using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Services;

public class ModelService(IModelRepository repository) : IModelService
{
    public Task<Model> CreateAsync(CreateModelRequest request)
    {
        return repository.CreateAsync(request);
    }

    public Task<Model?> GetAsync(Guid id)
    {
        return repository.GetAsync(id);
    }

    public Task<IEnumerable<Model>> GetAllAsync()
    {
        return repository.GetAllAsync();
    }
}