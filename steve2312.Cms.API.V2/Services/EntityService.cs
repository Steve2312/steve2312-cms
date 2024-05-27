using steve2312.Cms.API.V2.Exceptions;
using steve2312.Cms.API.V2.Repositories;
using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public class EntityService(IEntityRepository entityRepository, IModelRepository modelRepository) : IEntityService
{
    public async Task<Entity> CreateWithModelIdAsync(CreateEntityRequest request, Guid modelId)
    {
        var model = await modelRepository.GetAsync(modelId);

        if (model == null) throw new ModelNotFoundException();
        
        var entity = request.ToModel(model);
        
        entity.StringValueFields = entity.StringValueFields?
            .Where(valueField => model.StringKeyFields?.FirstOrDefault(keyField => keyField.Id == valueField.KeyFieldId) != null)
            .ToList();
        
        entity.IntegerValueFields = entity.IntegerValueFields?
            .Where(valueField => model.IntegerKeyFields?.FirstOrDefault(keyField => keyField.Id == valueField.KeyFieldId) != null)
            .ToList();
        
        return await entityRepository.CreateAsync(entity);
    }
    
    public Task<IEnumerable<Entity>?> GetAllByModelIdAsync(Guid id)
    {
        return entityRepository.GetAllByModelIdAsync(id);
    }

    public Task<Entity?> GetAsync(Guid id)
    {
        return entityRepository.GetAsync(id);
    }
}