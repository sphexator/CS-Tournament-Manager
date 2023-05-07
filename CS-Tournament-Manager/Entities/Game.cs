using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

/// <inheritdoc />
public class Game : IGame
{
    /// <inheritdoc />
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <inheritdoc />
    public string Name { get; set; } = null!;
    
    /// <inheritdoc />
    public string Path { get; set; } = null!;

    /// <inheritdoc />
    public int TeamOneScore { get; set; } = 0;

    /// <inheritdoc />
    public int TeamTwoScore { get; set; } = 0;

    /// <inheritdoc />
    public Guid MatchId { get; set; }
    
    /// <inheritdoc />
    public Match Match { get; set; } = null!;
}