using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Match : IMatch
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int TeamOneScore { get; set; }
    public int TeamTwoScore { get; set; }
    public DateTimeOffset StartTime { get; set; }
    public Team TeamOne { get; set; }
    public Team TeamTwo { get; set; }
    public Team? Winner { get; set; }
    public List<Game> Games { get; set; }
    public Guid TournamentId { get; set; }
}