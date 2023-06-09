﻿using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Handlers.TournamentHandlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CS_Tournament_Manager.Controllers;

[ApiController]
public class TournamentController : ControllerBase
{
    private readonly IMediator _mediator;
    public TournamentController(IMediator mediator) => _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Get(int page, int pageSize)
    {
        var result = await _mediator.Send(new GetPaginatedTournament(page, pageSize));
        if(result.Count == 0) return NotFound();
        return Ok(result);
    }
    
    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetSpecificTournament(id));
        if (result is null) return NotFound();
        return Ok(result);
    }
    
    [HttpPost]
    public async Task<IActionResult> Post(Tournament tournament)
    {
        var result = await _mediator.Send(new CreateTournament(tournament));
        if (result is null) return NotFound();
        return Ok(result);
    }
    
    [HttpPut("{id:Guid}")]
    public async Task<IActionResult> Put(Guid id)
    {
        var result = await _mediator.Send(new UpdateTournament());
        if (result is null) return NotFound();
        return Ok(result);
    }
    
    [HttpDelete("{id:Guid}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _mediator.Send(new DeleteTournament(id));
        if (result is false) return BadRequest();
        return Ok();
    }
    
    [HttpGet("{id:Guid}/teams")]
    public async Task<IActionResult> GetTeams(Guid id)
    {
        var result = await _mediator.Send(new GetTeamsTournament(id));
        if(result.Count == 0) return NotFound();
        return Ok(result);
    }
    
    [HttpGet("{id:Guid}/matches")]
    public async Task<IActionResult> GetMatches(Guid id, int page, int pageSize)
    {
        var result = await _mediator.Send(new GetMatchesTournament(id, page, pageSize));
        if(result.Count == 0) return NotFound();
        return Ok(result);
    }
    
    [HttpGet("{id:Guid}/matches/{matchId:Guid}")]
    public async Task<IActionResult> GetMatch(Guid id, Guid matchId)
    {
        var result = await _mediator.Send(new GetMatchTournament(id, matchId));
        if (result is null) return NotFound();
        return Ok(result);
    }
}