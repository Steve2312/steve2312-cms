using steve2312.Cms.API.Repositories;
using steve2312.Cms.API.Requests;
using steve2312.Cms.DAL.Models;

namespace steve2312.Cms.API.Services;

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