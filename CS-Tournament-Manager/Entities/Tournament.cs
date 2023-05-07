using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

/// <inheritdoc />
public class Tournament : ITournament
{
    /// <inheritdoc />
    public Guid Id { get; set; }
    
    /// <inheritdoc />
    public string Name { get; set; }
    
    /// <inheritdoc />
    public int Seed { get; set; }

    /// <inheritdoc />
    public string TournamentStyle { get; set; }
    
    /// <inheritdoc />
    public TimeSpan EstimatedGameDuration { get; set; }
    
    /// <inheritdoc />
    public bool TournamentStatus { get; set; }
    
    /// <inheritdoc />
    public List<Team> Teams { get; set; }
}