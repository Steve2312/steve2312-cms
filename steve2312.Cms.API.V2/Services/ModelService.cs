using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

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