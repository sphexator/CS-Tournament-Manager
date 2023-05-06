using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetSpecificTournament(Guid Id) : IRequest<ITournament>;

public class GetSpecificTournamentHandler : IRequestHandler<GetSpecificTournament, ITournament>
{
    private readonly DbService _db;
    public GetSpecificTournamentHandler(DbService db) => _db = db;

    public async Task<ITournament> Handle(GetSpecificTournament request, CancellationToken cancellationToken)
    {
        var result = await _db.Tournaments.FindAsync(new object?[] { request.Id },
            cancellationToken: cancellationToken);
        if(result is null) throw new NullReferenceException("Tournament not found");
        return result;
    }
}