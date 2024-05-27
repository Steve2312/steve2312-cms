using steve2312.Cms.API.V2.Exceptions;
using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public class ModelService(IModelRepository repository) : IModelService
{
    public Task<Model> CreateAsync(CreateModelRequest request)
    {
        var model = request.ToModel();
        
        return repository.CreateAsync(model);
    }

    public async Task<Model> GetAsync(Guid id)
    {
        var model = await repository.GetAsync(id);

        if (model == null) throw new ModelNotFoundException();
        
        return model;
    }

    public Task<IEnumerable<Model>> GetAllAsync()
    {
        return repository.GetAllAsync();
    }
}