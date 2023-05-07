using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Team : ITeam
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool CaptainMode { get; set; }
    public Player? Captain { get; set; }
    public List<Player> Players { get; set; }
    public Guid TournamentId { get; set; }
}