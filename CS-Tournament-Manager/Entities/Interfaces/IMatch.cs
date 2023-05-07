namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IMatch : INamedEntity
{
    int TeamOneScore { get; set; }
    int TeamTwoScore { get; set; }
    Team TeamOne { get; set; }
    Team TeamTwo { get; set; }
    Team? Winner { get; set; }
    
    List<Game> Games { get; set; }
    Guid TournamentId { get; set; }
}