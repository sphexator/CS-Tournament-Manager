namespace CS_Tournament_Manager.Entities.Interfaces;

public interface ITournament : INamedEntity
{
    /// <summary>
    /// Tournament seed number - used to determine the order of teams in the tournament
    /// </summary>
    int Seed { get; set; }
    /// <summary>
    /// Type of tournament style, e.g. Single Elimination, Double Elimination, Round Robin, etc.
    /// </summary>
    string TournamentStyle { get; set; }
    /// <summary>
    /// Estimate amount of time a single game will take
    /// </summary>
    TimeSpan EstimatedGameDuration { get; set; }
    /// <summary>
    /// Whether tournament is currently running
    /// </summary>
    bool TournamentStatus { get; set; }
    
    /// <summary>
    /// List of teams participating in the tournament
    /// </summary>
    List<Team> Teams { get; set; }
}