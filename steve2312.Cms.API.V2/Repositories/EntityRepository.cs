using Microsoft.EntityFrameworkCore;
using steve2312.Cms.DAL.V2;
using steve2312.Cms.DAL.V2.Models;

namespace steve2312.Cms.API.V2.Repositories;

public class EntityRepository(CmsDbContext context) : IEntityRepository
{
    public async Task<IEnumerable<Entity>?> GetAllByModelIdAsync(Guid id)
    {
        var model = await context.Models
            .Include(model => model.StringKeyFields)
            .Include(model => model.Entities)!
            .ThenInclude(entity => entity.StringValueFields)
            .FirstOrDefaultAsync(model => model.Id == id);

        return model?.Entities;
    }

    public Task<Entity?> GetAsync(Guid id)
    {
        return context.Entities
            .Include(entity => entity.StringValueFields)
            .Include(entity => entity.Model)
            .ThenInclude(model => model!.StringKeyFields)
            .FirstOrDefaultAsync(entity => entity.Id == id);
    }
}