using CS_Tournament_Manager.Handlers.TournamentHandlers;
using MediatR;

namespace CS_Tournament_Manager.Tests.Mediatr.TournamentHandlers;

public class UpdateTournamentHandlerTests
{
    [Fact]
    public async Task Update_Tournament_By_Valid_Id_Expect_Success()
    {
        // Arrange
        var handler = new UpdateTournamentHandler();
        var request = new UpdateTournament
        {
            
        };
        
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.NotNull(result);
    }
    
    [Fact]
    public async Task Update_Tournament_By_Invalid_Id_Expect_Failure()
    {
        // Arrange
        var handler = new UpdateTournamentHandler();
        var request = new UpdateTournament
        {
            
        };
        
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.Null(result);
    }
    
    [Fact]
    public async Task Update_Tournament_Name_By_Valid_Id_Expect_Success()
    {
        // Arrange
        const string newName = "new test tournament name";
        var handler = new UpdateTournamentHandler();
        var request = new UpdateTournament
        {
            
        };
        // Act
        var result = await handler.Handle(request, CancellationToken.None);
        
        // Assert
        Assert.Equal(newName, result.Name);
    }
}