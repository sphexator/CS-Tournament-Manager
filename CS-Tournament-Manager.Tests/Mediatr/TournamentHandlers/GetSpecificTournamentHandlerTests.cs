using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class GetSpecificTournamentHandlerTests
{
    // [Fact]
    // public async Task Get_Specific_Tournament_By_Valid_Id_Expect_Success()
    // {
    //     // Arrange
    //     var db = new Mock<IDbService>();
    //     var tournamentId = Guid.NewGuid();
    //     db.SetupSequence(e => e.Tournaments).ReturnsDbSet(new List<Tournament>()
    //     {
    //         new() { Id = tournamentId },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() }
    //     });
    //     var request = new GetSpecificTournament(tournamentId);
    //     var handler = new GetSpecificTournamentHandler(db.Object);
    //     // Act
    //     var result = await handler.Handle(request, CancellationToken.None);
    //     // Assert
    //     Assert.NotNull(result);
    //     Assert.True(result.Id == tournamentId);
    // }
    //
    // [Fact]
    // public async Task Get_Specific_Tournament_By_Invalid_Id_Expect_Failure()
    // {
    //     // Arrange
    //     var db = new Mock<IDbService>();
    //     var tournamentId = Guid.NewGuid();
    //     db.SetupSequence(e => e.Tournaments).ReturnsDbSet(new List<Tournament>()
    //     {
    //         new() { Id = tournamentId },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() },
    //         new() { Id = Guid.NewGuid() }
    //     });
    //     var request = new GetSpecificTournament(tournamentId);
    //     var handler = new GetSpecificTournamentHandler(db.Object);
    //     // Act
    //     var result = await handler.Handle(request, CancellationToken.None);
    //     // Assert
    //     Assert.Null(result);
    // }
}