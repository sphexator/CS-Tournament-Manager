using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetTeamsTournament(Guid Id) : IRequest<List<Team>>;

public class GetTeamsTournamentHandler : IRequestHandler<GetTeamsTournament, List<Team>>
{
    private readonly DbService _db;
    public GetTeamsTournamentHandler(DbService db) => _db = db;

    public async Task<List<Team>> Handle(GetTeamsTournament request, CancellationToken cancellationToken)
    {
        var results = await _db.Teams.Where(x => x.TournamentId == request.Id).ToListAsync(cancellationToken);
        return results;
    }
}