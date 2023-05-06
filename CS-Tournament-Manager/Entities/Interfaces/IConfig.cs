namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IConfig : INamedEntity
{
    /// <summary>
    /// Number of game servers to run simultaneously - Cannot be higher than the number of GSL tokens
    /// </summary>
    int ConcurrentGames { get; set; }
    /// <summary>
    /// Amount of teams that fits into this tournament - 0 = unlimited
    /// </summary>
    int NumberOfTeams { get; set; }
    /// <summary>
    /// Amount of players per team. Does not include substitutes, coaches, etc.
    /// </summary>
    int NumberOfPlayersPerTeam { get; set; }
    
    /// <summary>
    /// List of GSL tokens to use for creation of game servers
    /// </summary>
    List<string> SteamGslTokens { get; set; }
}