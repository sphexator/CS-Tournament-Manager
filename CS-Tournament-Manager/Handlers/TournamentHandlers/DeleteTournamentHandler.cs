using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record DeleteTournament(Guid Id) : IRequest<bool>;

public class DeleteTournamentHandler : IRequestHandler<DeleteTournament, bool>
{
    private readonly IDbService _db;

    public DeleteTournamentHandler(IDbService db) => _db = db;

    public async Task<bool> Handle(DeleteTournament request, CancellationToken cancellationToken)
    {
        var tournament = await _db.Tournaments.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (tournament is null) return false;
        _db.Tournaments.Remove(tournament);
        await _db.SaveChangesAsync(cancellationToken);
        return true;
    }
}