using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CS_Tournament_Manager.Controllers;

[ApiController]
public class TeamController : ControllerBase
{
    private readonly IMediator _mediator;

    public TeamController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpPost]
    public async Task<IActionResult> Create()
    {
        throw new NotImplementedException();
    }
    
    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Update(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("{id:Guid}/players")]
    public async Task<IActionResult> GetPlayers(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("{id:Guid}/matches")]
    public async Task<IActionResult> GetMatches(Guid id)
    {
        throw new NotImplementedException();
    }
    
    [HttpGet("{id:Guid}/matches/{matchId:Guid}")]
    public async Task<IActionResult> GetMatch(Guid id, Guid matchId)
    {
        throw new NotImplementedException();
    }
}