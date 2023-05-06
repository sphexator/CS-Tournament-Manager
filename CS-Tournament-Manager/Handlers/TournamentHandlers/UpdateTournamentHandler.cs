using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record UpdateTournament() : IRequest<ITournament>;

public class UpdateTournamentHandler : IRequestHandler<UpdateTournament, ITournament>
{
    public async Task<ITournament> Handle(UpdateTournament request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}