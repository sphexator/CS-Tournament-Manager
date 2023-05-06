using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetMatchTournament(Guid TournamentId, Guid Id) : IRequest<IMatch>;

public class GetMatchTournamentHandler : IRequestHandler<GetMatchTournament, IMatch>
{
    private readonly DbService _db;
    public GetMatchTournamentHandler(DbService db) => _db = db;

    public async Task<IMatch> Handle(GetMatchTournament request, CancellationToken cancellationToken)
    {
        var result = await _db.Matches.FindAsync(
            new object?[] { request.Id, request.TournamentId }, 
            cancellationToken: cancellationToken);
        if (result is null) throw new NullReferenceException("Match not found");
        return result;
    }
}