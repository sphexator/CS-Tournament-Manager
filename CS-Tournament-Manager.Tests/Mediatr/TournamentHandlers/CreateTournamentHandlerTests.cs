using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;
using Moq;
using Moq.EntityFrameworkCore;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class CreateTournamentHandlerTests
{
    private readonly CreateTournament _request = new (new Tournament()
    {
        Id = Guid.NewGuid(),
        Name = "New tournament",
        Seed = 420,
        TournamentStatus = true,
        TournamentStyle = "swiss",
        EstimatedGameDuration = TimeSpan.FromHours(1),
        Teams = new List<Team>()
    });

    [Fact]
    public async Task Create_Tournament_Expect_Success()
    {
        // Arrange
        var db = new Mock<IDbService>();
        db.SetupSequence(x => x.Tournaments).ReturnsDbSet(new List<Tournament> { _request.Tournament });
        var handler = new CreateTournamentHandler(db.Object);

        // Act
        var result = await handler.Handle(_request, CancellationToken.None);
        
        // Assert
        Assert.NotNull(result);
    }
    
    [Fact]
    public async Task Create_Tournament_With_Invalid_Name_Expect_Failure()
    {
        // Arrange
        var db = new Mock<IDbService>();
        var handler = new CreateTournamentHandler(db.Object);
        _request.Tournament.Name = "";
        // Act
        var result = await handler.Handle(_request, CancellationToken.None);
        
        // Assert
        Assert.Null(result);
    }
}