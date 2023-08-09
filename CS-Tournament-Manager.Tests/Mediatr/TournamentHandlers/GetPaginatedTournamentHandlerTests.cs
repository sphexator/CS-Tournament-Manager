using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using CS_Tournament_Manager.Handlers.TournamentHandlers;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class GetPaginatedTournamentHandlerTests
{
    // [Fact]
    // public async Task Get_5_Tournaments_Skipped_By_5_Expect_5()
    // {
    //     // Arrange
    //     var request = new GetPaginatedTournament(2, 5);
    //     var db = new Mock<IDbService>();
    //     var tournaments = GetTournaments();
    //     var expected = tournaments.OrderBy(x => x.CreatedAt).Skip(5).Take(5).ToList();
    //     db.SetupSequence(e => e.Tournaments).ReturnsDbSet(tournaments);
    //     var handler = new GetPaginatedTournamentHandler(db.Object);
    //     // Act
    //     var result = await handler.Handle(request, CancellationToken.None);
    //     
    //     // Assert
    //     Assert.NotEmpty(result);
    //     for (var i = 0; i < result.Count; i++)
    //     {
    //         Assert.True(expected[i] == result[i]);
    //     }
    // }
    //
    // [Fact]
    // public async Task Get_5_Tournaments_Skipped_By_10_Expect_0()
    // {
    //     // Arrange
    //     var request = new GetPaginatedTournament(3, 5);
    //     var db = new Mock<IDbService>();
    //     var handler = new GetPaginatedTournamentHandler(db.Object);
    //     var tournaments = GetTournaments();
    //     db.SetupSequence(e => e.Tournaments).ReturnsDbSet(tournaments);
    //     // Act
    //     var result = await handler.Handle(request, CancellationToken.None);
    //     // Assert
    //     Assert.Empty(result);
    // }
    //
    // [Fact]
    // public async Task Get_5_Tournaments_Skipped_By_0_Expect_5()
    // {
    //     // Arrange
    //     var request = new GetPaginatedTournament(1, 5);
    //     var db = new Mock<IDbService>();
    //     var tournaments = GetTournaments();
    //     var expected = tournaments.OrderBy(x => x.CreatedAt).Skip(0).Take(5).ToList();
    //     db.SetupSequence(e => e.Tournaments).ReturnsDbSet(tournaments);
    //     var handler = new GetPaginatedTournamentHandler(db.Object);
    //     // Act
    //     var result = await handler.Handle(request, CancellationToken.None);
    //     // Assert
    //     Assert.NotEmpty(result);
    //     for (var i = 0; i < result.Count; i++)
    //     {
    //         Assert.True(expected[i] == result[i]);
    //     }
    // }
    //
    // private static List<Tournament> GetTournaments()
    // {
    //     var result = new List<Tournament>();
    //     for (var i = 0; i < 10; i++)
    //     {
    //         result.Add(new ()
    //         {
    //             Id = Guid.NewGuid(),
    //             CreatedAt = DateTimeOffset.UtcNow + TimeSpan.FromMinutes(0 + 1)
    //         });
    //     }
    //
    //     return result;
    // }
}