using CS_Tournament_Manager.Database;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record DeleteTournament(Guid Id) : IRequest;

public class DeleteTournamentHandler : IRequestHandler<DeleteTournament>
{
    private readonly DbService _db;

    public DeleteTournamentHandler(DbService db) => _db = db;

    public async Task Handle(DeleteTournament request, CancellationToken cancellationToken)
    {
        var tournament = await _db.Tournaments.FindAsync(new object?[] { request.Id }, cancellationToken: cancellationToken);
        if (tournament is null) throw new NullReferenceException("Tournament not found");
        _db.Tournaments.Remove(tournament);
        await _db.SaveChangesAsync(cancellationToken);
    }
}