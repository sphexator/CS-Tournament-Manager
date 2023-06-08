using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetSpecificTournament(Guid Id) : IRequest<ITournament>;

public class GetSpecificTournamentHandler : IRequestHandler<GetSpecificTournament, ITournament>
{
    private readonly IDbService _db;
    public GetSpecificTournamentHandler(IDbService db) => _db = db;

    public async Task<ITournament> Handle(GetSpecificTournament request, CancellationToken cancellationToken)
    {
        var result = await _db.Tournaments.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        return result;
    }
}