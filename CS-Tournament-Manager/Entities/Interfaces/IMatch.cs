namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IMatch : INamedEntity
{
    int TeamOneScore { get; set; }
    int TeamTwoScore { get; set; }
    ITeam TeamOne { get; set; }
    ITeam TeamTwo { get; set; }
    ITeam? Winner { get; set; }
    
    List<IGame> Games { get; set; }
    Guid TournamentId { get; set; }
}