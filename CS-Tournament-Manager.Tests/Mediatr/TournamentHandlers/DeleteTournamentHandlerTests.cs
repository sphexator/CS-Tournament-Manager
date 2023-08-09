using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class DeleteTournamentHandlerTests
{
    // [Fact]
    // public async Task Delete_Tournament_By_Valid_Id_Expect_Success()
    // {
    //     // Arrange
    //     var db = new Mock<IDbService>();
    //     var guid = Guid.NewGuid();
    //     db.Setup(o => o.Tournaments).ReturnsDbSet( new []{new Tournament()
    //     {
    //         Id = guid,
    //         Name = "New tournament",
    //         Seed = 420,
    //         TournamentStatus = true,
    //         TournamentStyle = "swiss",
    //         EstimatedGameDuration = TimeSpan.FromHours(1),
    //         Teams = new List<Team>()
    //     }});
    //     var handler = new DeleteTournamentHandler(db.Object);
    //     
    //     // Act
    //     var result = await handler.Handle(new DeleteTournament(guid), CancellationToken.None);
    //     
    //     // Assert
    //     Assert.True(result);
    // }
    //
    // [Fact]
    // public async Task Delete_Tournament_By_Invalid_Id_Expect_Failure()
    // {
    //     // Arrange
    //     var db = new Mock<IDbService>();
    //     var guid = Guid.NewGuid();
    //     db.SetupSequence(x => x.Tournaments).ReturnsDbSet(new List<Tournament> { new ()
    //     {
    //         Id = guid,
    //         Name = "New tournament",
    //         Seed = 420,
    //         TournamentStatus = true,
    //         TournamentStyle = "swiss",
    //         EstimatedGameDuration = TimeSpan.FromHours(1),
    //         Teams = new List<Team>()
    //     } });
    //     var handler = new DeleteTournamentHandler(db.Object);
    //     
    //     // Act
    //     var result = await handler.Handle(new DeleteTournament(Guid.NewGuid()), CancellationToken.None);
    //     
    //     // Assert
    //     Assert.False(result);
    // }
}