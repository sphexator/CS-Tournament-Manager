using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record CreateTournament() : IRequest<ITournament>;


public class CreateTournamentHandler : IRequestHandler<CreateTournament, ITournament>
{
    private readonly DbService _dbService;

    public CreateTournamentHandler(DbService dbService) => _dbService = dbService;

    public async Task<ITournament> Handle(CreateTournament request, CancellationToken cancellationToken)
    {
        var tournament = new Tournament{ Id = Guid.NewGuid() };
        await _dbService.Tournaments.AddAsync(tournament, cancellationToken);
        await _dbService.SaveChangesAsync(cancellationToken);
        return tournament;
    }
}