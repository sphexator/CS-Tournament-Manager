using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;
using Moq;
using Moq.EntityFrameworkCore;
using Match = CS_Tournament_Manager.Entities.Match;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class GetMatchTournamentHandlerTests
{
    [Fact]
    public async Task Get_Match_With_Valid_Tournament_Id_And_Valid_Match_Id_Expect_Success()
    {
        // Arrange
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(tournamentId, matchId);
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.NotNull(result);
        Assert.True(result.Id == matchId);
        Assert.True(result.TournamentId == tournamentId);
    }
    
    [Fact]
    public async Task Get_Match_With_Invalid_Id_Expect_Failure()
    {
        // Arrange
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(tournamentId, Guid.NewGuid());
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Get_Match_With_Invalid_Tournament_Id_Expect_Failure()
    {
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(Guid.NewGuid(), matchId);
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Get_Match_With_Invalid_Match_Id_Expect_Failure()
    {
        // Arrange
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(tournamentId, Guid.NewGuid());
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Get_Match_With_Invalid_Tournament_Id_And_Invalid_Match_Id_Expect_Failure()
    {
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(Guid.NewGuid(), Guid.NewGuid());
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Get_Match_With_Invalid_Tournament_Id_And_Valid_Match_Id_Expect_Failure()
    {
        // Arrange
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(Guid.NewGuid(), matchId);
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Get_Match_With_Valid_Tournament_Id_And_Invalid_Match_Id_Expect_Failure()
    {
        // Arrange
        var tournamentId = Guid.NewGuid();
        var matchId = Guid.NewGuid();
        var request = new GetMatchTournament(tournamentId, Guid.NewGuid());
        var db = new Mock<IDbService>();
        db.Setup(e => e.Matches).ReturnsDbSet(new[]
        {
            new Match { Id = matchId, TournamentId = tournamentId },
            new Match { Id = Guid.NewGuid(), TournamentId = Guid.NewGuid() },
            new Match {Id = matchId, TournamentId = Guid.NewGuid() } ,
            new Match { Id = Guid.NewGuid(), TournamentId = tournamentId}
        });
        var handler = new GetMatchTournamentHandler(db.Object);
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        // Assert
        Assert.Null(result);
    }
}