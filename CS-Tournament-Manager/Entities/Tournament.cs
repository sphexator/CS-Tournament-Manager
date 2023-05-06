using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Tournament : ITournament
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Seed { get; set; }
    public string TournamentStyle { get; set; }
    public TimeSpan EstimatedGameDuration { get; set; }
    public bool TournamentStatus { get; set; }
    public List<ITeam> Teams { get; set; }
}