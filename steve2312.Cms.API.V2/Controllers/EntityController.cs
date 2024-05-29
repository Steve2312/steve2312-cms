using System.Text.Json.Nodes;
using Microsoft.AspNetCore.Mvc;
using steve2312.Cms.API.V2.Exceptions;
using steve2312.Cms.API.V2.Requests;
using steve2312.Cms.API.V2.Responses;
using steve2312.Cms.API.V2.Services;

namespace steve2312.Cms.API.V2.Controllers;

[ApiController]
[Route("api/entities")]
public class EntityController(IEntityService entityService, ISerializationService serializationService) : Controller
{
    /// <summary>
    /// Retrieve all entities from specific model
    /// </summary>
    /// <response code="200">Entities returned successfully</response>
    /// <response code="404">Model with specified id could not be found</response>
    [HttpGet("model/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EntityResponse>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllByModelId(Guid id)
    {
        var entities = await entityService.GetAllByModelIdAsync(id);

        if (entities == null)
        {
            return NotFound();
        }

        var response = entities.Select(EntityResponseExtensions.ToResponse);

        return Ok(response);
    }
    
    /// <summary>
    /// Create entity from specific model
    /// </summary>
    /// <response code="200">Entities returned created</response>
    /// <response code="400">Received model seems invalid</response>
    /// <response code="404">Model with specified id could not be found</response>
    [HttpPut("model/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<EntityResponse>))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> CreateWithModelId(Guid id, CreateEntityRequest request)
    {
        try
        {
            var entity = await entityService.CreateWithModelIdAsync(request, id);
            var response = entity.ToResponse();

            return Ok(response);
        }
        catch (ModelNotFoundException)
        {
            return NotFound();
        }
        catch (RequiredKeyValueFieldNotFound)
        {
            return BadRequest();
        }
    }
    
    /// <summary>
    /// Retrieve all serialized entities from specific model
    /// </summary>
    /// <response code="200">Serialized entities returned successfully</response>
    /// <response code="404">Model with specified id could not be found</response>
    [HttpGet("model/{id}/serialized")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> GetAllSerializedByModelId(Guid id)
    {
        var entities = await entityService.GetAllByModelIdAsync(id);

        if (entities == null)
        {
            return NotFound();
        }

        var response = entities.Select(serializationService.Serialize);

        return Ok(response);
    }
    
    /// <summary>
    /// Get entity by its primary key
    /// </summary>
    /// <response code="200">Entity returned successfully</response>
    /// <response code="404">Entity with specified id could not be found</response>
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(EntityResponse))]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Get(Guid id)
    {
        var entity = await entityService.GetAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        var response = entity.ToResponse();

        return Ok(response);
    }
    
    /// <summary>
    /// Get entity by its primary key and return it in serialized format
    /// </summary>
    /// <response code="200">Serialized entity returned successfully</response>
    /// <response code="404">Entity with specified id could not be found</response>
    /// <response code="500">Entity was not able to be serialized</response>
    [HttpGet("{id}/serialized")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> GetSerialized(Guid id)
    {
        var entity = await entityService.GetAsync(id);

        if (entity == null)
        {
            return NotFound();
        }

        var response = serializationService.Serialize(entity);

        if (response == null)
        {
            return StatusCode(500);
        }

        return Ok(response);
    }
}