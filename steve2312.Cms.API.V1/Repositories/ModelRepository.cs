using Microsoft.EntityFrameworkCore;
using steve2312.Cms.API.V1.Requests;
using steve2312.Cms.DAL.V1;
using steve2312.Cms.DAL.V1.Models;

namespace steve2312.Cms.API.V1.Repositories;

public class ModelRepository(CmsDbContext context) : IModelRepository
{
    public async Task<Model> CreateAsync(CreateModelRequest request)
    {
        var model = request.ToModel();

        await context.Models.AddAsync(model);
        await context.SaveChangesAsync();

        return model;
    }

    public async Task<Model?> GetAsync(Guid id)
    {
        return await context.Models
            .Include(model => model.KeyFields)
            .FirstOrDefaultAsync(model => model.Id == id);
    }

    public async Task<IEnumerable<Model>> GetAllAsync()
    {
        return await context.Models
            .Include(model => model.KeyFields)
            .ToListAsync();
    }
}