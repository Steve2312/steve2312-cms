using Microsoft.AspNetCore.Mvc;
using steve2312.Cms.API.Requests;
using steve2312.Cms.API.Responses;
using steve2312.Cms.API.Services;

namespace steve2312.Cms.API.Controllers;

[ApiController]
[Route("api/models")]
public class ModelController(IModelService service) : Controller
{
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ModelResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id)
    {
        var model = await service.GetAsync(id);

        if (model == null) return NotFound();
        
        var response = model.ToResponse();

        return Ok(response);
    }
        
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModelResponse>))]
    public async Task<IActionResult> GetAll()
    {
        var models = await service.GetAllAsync();
        var response = models.Select(ModelResponseExtensions.ToResponse);

        return Ok(response);
    }
    
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ModelResponse))]
    public async Task<IActionResult> Create(CreateModelRequest request)
    {
        var model = await service.CreateAsync(request);
        var response = model.ToResponse();

        return Ok(response);
    }
}