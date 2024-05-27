using Microsoft.AspNetCore.Mvc;
using steve2312.Cms.API.V2.Exceptions;
using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.API.V2.Responses;
using steve2312.Cms.API.V2.Services;

namespace steve2312.Cms.API.V2.Controllers;

[ApiController]
[Route("api/models")]
public class ModelController(IModelService service) : Controller
{
    /// <summary>
    /// Retrieve all models
    /// </summary>
    /// <response code="200">Models returned successfully</response>
    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<ModelResponse>))]
    public async Task<IActionResult> GetAll()
    {
        var models = await service.GetAllAsync();
        var response = models.Select(ModelResponseExtensions.ToResponse);

        return Ok(response);
    }
    
    /// <summary>
    /// Get model by its primary key
    /// </summary>
    /// <response code="200">Model returned successfully</response>
    /// <response code="404">Model with specified id could not be found</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ModelResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id)
    {
        try
        {
            var model = await service.GetAsync(id);
            var response = model.ToResponse();
            
            return Ok(response);
        }
        catch (ModelNotFoundException)
        {
            return NotFound();
        }
    }
    
    /// <summary>
    /// Create new model
    /// </summary>
    /// <response code="200">Model returned successfully</response>
    /// <response code="404">Model with specified name could not be found</response>
    [HttpPut]
    [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(ModelResponse))]
    public async Task<IActionResult> Create(CreateModelRequest request)
    {
        var model = await service.CreateAsync(request);
        var response = model.ToResponse();

        return Ok(response);
    }
}