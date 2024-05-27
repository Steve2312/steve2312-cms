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
            .Include(model => model.IntegerKeyFields)
            .Include(model => model.Entities)!
                .ThenInclude(entity => entity.StringValueFields)
            .Include(model => model.Entities)!
                .ThenInclude(entity => entity.IntegerValueFields)
            .FirstOrDefaultAsync(model => model.Id == id);

        return model?.Entities;
    }

    public Task<Entity?> GetAsync(Guid id)
    {
        return context.Entities
            .Include(entity => entity.StringValueFields)
            .Include(model => model.IntegerValueFields)
            .Include(entity => entity.Model)
                .ThenInclude(model => model!.StringKeyFields)
            .Include(entity => entity.Model)
                .ThenInclude(model => model!.IntegerKeyFields)
            .FirstOrDefaultAsync(entity => entity.Id == id);
    }
}