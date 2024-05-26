using steve2312.Cms.API.Requests;
using steve2312.Cms.DAL.Models;

namespace steve2312.Cms.API.Services;

public interface IModelService
{
    Task<Model> CreateAsync(CreateModelRequest request);

    Task<Model?> GetAsync(Guid id);

    Task<IEnumerable<Model>> GetAllAsync();
}