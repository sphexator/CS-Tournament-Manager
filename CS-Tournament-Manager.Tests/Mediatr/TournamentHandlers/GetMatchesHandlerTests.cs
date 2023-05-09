using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;
using Moq;
using Moq.EntityFrameworkCore;
using Match = CS_Tournament_Manager.Entities.Match;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class GetMatchesHandlerTests
{
    [Fact]
    public async Task Get_5_Matches_Skipped_By_5_Expect_5()
    {
        // Arrange
        var id = Guid.NewGuid();
        var request = new GetMatchesTournament(id, 2, 5);
        var db = new Mock<IDbService>();
        var matches = GetMatches(id);
        var expected = matches.OrderBy(e => e.StartTime).Skip(5).Take(5).ToList();
        db.SetupSequence(x => x.Tournaments).ReturnsDbSet(new List<Tournament> { new ()
        {
            Id = id,
            Name = "New tournament",
            Seed = 420,
            Teams = new List<Team>(),
            TournamentStatus = true,
            TournamentStyle = "swiss",
            EstimatedGameDuration = TimeSpan.FromHours(1)
        } });
        db.SetupSequence(x => x.Matches).ReturnsDbSet(matches);
        var handler = new GetMatchesTournamentHandler(db.Object);

        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.NotEmpty(result);
        for (var i = 0; i < result.Count; i++)
        {
            var x = result[i];
            Assert.True(expected[i].Id == x.Id);
        }
    }
    
    [Fact]
    public async Task Get_5_Matches_Skipped_By_10_Expect_0()
    {
        // Arrange
        var id = Guid.NewGuid();
        var request = new GetMatchesTournament(id, 3, 5);
        var db = new Mock<IDbService>();
        var matches = GetMatches(id);
        var expected = matches.OrderBy(e => e.StartTime).Skip(10).Take(5).ToList();
        db.SetupSequence(x => x.Tournaments).ReturnsDbSet(new List<Tournament> { new ()
        {
            Id = id,
            Name = "New tournament",
            Seed = 420,
            Teams = new List<Team>(),
            TournamentStatus = true,
            TournamentStyle = "swiss",
            EstimatedGameDuration = TimeSpan.FromHours(1)
        } });
        db.SetupSequence(x => x.Matches).ReturnsDbSet(matches);
        var handler = new GetMatchesTournamentHandler(db.Object);

        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public async Task Get_5_Matches_Skipped_By_0_Expect_5()
    {
        // Arrange
        var id = Guid.NewGuid();
        var request = new GetMatchesTournament(id, 1, 5);
        var db = new Mock<IDbService>();
        var matches = GetMatches(id);
        var expected = matches.OrderBy(e => e.StartTime).Skip(0).Take(5).ToList();
        db.SetupSequence(x => x.Tournaments).ReturnsDbSet(new List<Tournament> { new ()
        {
            Id = id,
            Name = "New tournament",
            Seed = 420,
            Teams = new List<Team>(),
            TournamentStatus = true,
            TournamentStyle = "swiss",
            EstimatedGameDuration = TimeSpan.FromHours(1)
        } });
        db.SetupSequence(x => x.Matches).ReturnsDbSet(matches);
        var handler = new GetMatchesTournamentHandler(db.Object);

        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.NotEmpty(result);
        for (var i = 0; i < result.Count; i++)
        {
            var x = result[i];
            Assert.True(expected[i].Id == x.Id);
        }
    }

    private static List<Match> GetMatches(Guid tournamentId)
    {
        var matches = new List<Match>();
        for (var i = 0; i < 10; i++)
        {
            matches.Add(new Match
            {
                TournamentId = tournamentId,
                TeamTwo = new Team(),
                TeamOne = new Team(),
                Games = new List<Game>(),
                TeamOneScore = 0,
                TeamTwoScore = 0,
                Winner = null,
                Id = Guid.NewGuid(),
                Name = "Match",
                StartTime = DateTimeOffset.UtcNow + TimeSpan.FromMinutes(i + 1)
            });
        }

        return matches;
    }
}