using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record CreateTournament(Tournament Tournament) : IRequest<ITournament>;


public class CreateTournamentHandler : IRequestHandler<CreateTournament, ITournament>
{
    private readonly IDbService _dbService;

    public CreateTournamentHandler(IDbService dbService) => _dbService = dbService;

    public async Task<ITournament> Handle(CreateTournament request, CancellationToken cancellationToken)
    {
        if(request.Tournament.Id == Guid.Empty) request.Tournament.Id = Guid.NewGuid();
        if (request.Tournament.Name.Trim() is null or "") return null;
        await _dbService.Tournaments.AddAsync(request.Tournament, cancellationToken);
        await _dbService.SaveChangesAsync(cancellationToken);
        return request.Tournament;
    }
}