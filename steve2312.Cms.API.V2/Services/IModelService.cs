using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Services;

public interface IModelService
{
    Task<Model> CreateAsync(CreateModelRequest request);
    Task<Model?> GetAsync(Guid id);
    Task<IEnumerable<Model>> GetAllAsync();
}