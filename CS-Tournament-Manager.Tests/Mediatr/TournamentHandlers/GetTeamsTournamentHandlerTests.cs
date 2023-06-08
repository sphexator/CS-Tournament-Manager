using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;
using Moq;
using Moq.EntityFrameworkCore;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class GetTeamsTournamentHandlerTests
{
    [Fact]
    public async Task Get_Teams_By_Valid_Id_Expect_Success()
    {
        // Arrange
        var db = new Mock<IDbService>();
        var tournamentId = Guid.NewGuid();
        var tournaments = CreateTournaments(tournamentId);
        db.SetupSequence(e => e.Teams).ReturnsDbSet(tournaments);
        var request = new GetTeamsTournament(tournamentId);
        var handler = new GetTeamsTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.NotNull(result);
        for (var i = 0; i < result.Count; i++)
        {
            Assert.True(tournaments[i] == result[i]);
        }
    }
    
    [Fact]
    public async Task Get_Teams_By_Invalid_Id_Expect_Failure()
    {
        // Arrange
        var db = new Mock<IDbService>();
        var tournamentId = Guid.NewGuid();
        var tournaments = CreateTournaments(tournamentId);
        db.SetupSequence(e => e.Teams).ReturnsDbSet(tournaments);
        var request = new GetTeamsTournament(Guid.NewGuid());
        var handler = new GetTeamsTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Empty(result);
    }

    private static List<Team> CreateTournaments(Guid tournamentId)
    {
        var toReturn = new List<Team>();
        for (var i = 0; i < 10; i++)
        {
            toReturn.Add(new Team
            {
                Id = Guid.NewGuid(),
                TournamentId = tournamentId,
                CreatedAt = DateTimeOffset.UtcNow + TimeSpan.FromHours( i + 1)
            });
        }

        return toReturn;
    }
}