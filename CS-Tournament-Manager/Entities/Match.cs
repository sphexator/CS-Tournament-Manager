using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Match : IMatch
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int TeamOneScore { get; set; }
    public int TeamTwoScore { get; set; }
    public ITeam TeamOne { get; set; }
    public ITeam TeamTwo { get; set; }
    public ITeam? Winner { get; set; }
    public List<IGame> Games { get; set; }
    public Guid TournamentId { get; set; }
}