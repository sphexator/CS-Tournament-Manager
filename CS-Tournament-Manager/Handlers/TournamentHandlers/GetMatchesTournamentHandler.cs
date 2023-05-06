using CS_Tournament_Manager.Database;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetMatchesTournament(Guid TournamentId, int PageNumber, int PageSize) : IRequest<List<IMatch>>;

public class GetMatchesTournamentHandler : IRequestHandler<GetMatchesTournament, List<IMatch>>
{
    private readonly DbService _db;
    public GetMatchesTournamentHandler(DbService db) => _db = db;

    public async Task<List<IMatch>> Handle(GetMatchesTournament request, CancellationToken cancellationToken)
    {
        var paginationSkip = (request.PageNumber - 1) * request.PageSize;
        var result = await _db.Matches.Where(x => x.TournamentId == request.TournamentId)
            .Skip(paginationSkip)
            .Take(request.PageSize)
            .ToListAsync(cancellationToken);
        return new List<IMatch>(result);
    }
}