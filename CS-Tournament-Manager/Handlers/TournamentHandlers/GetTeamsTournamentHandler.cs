using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetTeamsTournament(Guid Id) : IRequest<List<Team>>;

public class GetTeamsTournamentHandler : IRequestHandler<GetTeamsTournament, List<Team>>
{
    private readonly IDbService _db;
    public GetTeamsTournamentHandler(IDbService db) => _db = db;

    public async Task<List<Team>> Handle(GetTeamsTournament request, CancellationToken cancellationToken) =>
        await _db.Teams
            .Where(x => x.TournamentId == request.Id)
            .OrderBy(x => x.Name)
            .ToListAsync(cancellationToken);
}