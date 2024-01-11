using Microsoft.AspNetCore.Mvc;
using MovieStore.Business.Services;
using MovieStore.Data.Entities;

namespace MovieStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActorController : ControllerBase
{
    private readonly IActorService _actorService;

    public ActorController(IActorService actorService)
    {
        _actorService = actorService;
    }

    // GET: api/actor
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Actor>>> GetAllActors()
    {
        var actors = await _actorService.GetAllActorsAsync();
        return Ok(actors);
    }

    // GET: api/actor/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Actor>> GetActor(int id)
    {
        try
        {
            var actor = await _actorService.GetActorByIdAsync(id);
            return Ok(actor);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }

    // POST: api/actor
    [HttpPost]
    public async Task<ActionResult<Actor>> CreateActor([FromBody] Actor actor)
    {
        var createdActor = await _actorService.CreateActorAsync(actor);
        return CreatedAtAction(nameof(GetActor), new { id = createdActor.Id }, createdActor);
    }

    // PUT: api/actor/5
    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateActor(int id, [FromBody] Actor actor)
    {
        try
        {
            await _actorService.UpdateActorAsync(id, actor);
            return NoContent();
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }

    // DELETE: api/actor/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteActor(int id)
    {
        try
        {
            await _actorService.DeleteActorAsync(id);
            return NoContent();
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
    }
}