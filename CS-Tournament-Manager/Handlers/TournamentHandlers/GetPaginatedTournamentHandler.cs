using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Handlers.TournamentHandlers;

public record GetPaginatedTournament(int Page, int PageSize) : IRequest<List<Tournament>>;

public class GetPaginatedTournamentHandler : IRequestHandler<GetPaginatedTournament, List<Tournament>>
{
    private readonly IDbService _dbService;
    public GetPaginatedTournamentHandler(IDbService dbService) => _dbService = dbService;

    public async Task<List<Tournament>> Handle(GetPaginatedTournament request, CancellationToken cancellationToken)
    {
        var skip = (request.Page - 1) * request.PageSize;
        var result = await _dbService.Tournaments
            .Where(x => x.CreatedAt >= DateTime.Now.AddDays(-7))
            .OrderBy(x => x.CreatedAt)
            .Skip(skip)
            .Take(request.PageSize)
            .ToListAsync(cancellationToken);
        return result;
    }
}