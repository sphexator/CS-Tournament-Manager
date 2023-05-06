using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Team : ITeam
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public bool CaptainMode { get; set; }
    public IPlayer? Captain { get; set; }
    public List<IPlayer> Players { get; set; }
    public Guid TournamentId { get; set; }
}