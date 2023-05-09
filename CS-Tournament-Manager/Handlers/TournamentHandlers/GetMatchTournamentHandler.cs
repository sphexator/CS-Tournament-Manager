using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetMatchTournament(Guid TournamentId, Guid Id) : IRequest<Match>;

public class GetMatchTournamentHandler : IRequestHandler<GetMatchTournament, Match>
{
    private readonly IDbService _db;
    public GetMatchTournamentHandler(IDbService db) => _db = db;

    public async Task<Match> Handle(GetMatchTournament request, CancellationToken cancellationToken)
    {
        var result = await _db.Matches.FirstOrDefaultAsync(x => x.Id == request.Id && x.TournamentId == request.TournamentId,
            cancellationToken);
        return result;
    }
}