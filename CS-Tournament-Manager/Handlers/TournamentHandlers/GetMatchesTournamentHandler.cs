using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetMatchesTournament(Guid TournamentId, int PageNumber, int PageSize) : IRequest<List<Match>>;

public class GetMatchesTournamentHandler : IRequestHandler<GetMatchesTournament, List<Match>>
{
    private readonly IDbService _db;
    public GetMatchesTournamentHandler(IDbService db) => _db = db;

    public async Task<List<Match>> Handle(GetMatchesTournament request, CancellationToken cancellationToken)
    {
        var paginationSkip = (request.PageNumber - 1) * request.PageSize;
        var result = await _db.Matches.Where(x => x.TournamentId == request.TournamentId)
            .OrderBy(x => x.StartTime)
            .Skip(paginationSkip)
            .Take(request.PageSize)
            .ToListAsync(cancellationToken);
        return result;
    }
}