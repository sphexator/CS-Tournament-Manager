namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IMatch
{
    Guid Id { get; set; }
    
    int TeamOneScore { get; set; }
    int TeamTwoScore { get; set; }
    
    ITeam TeamOne { get; set; }
    ITeam TeamTwo { get; set; }

    ITeam? Winner { get; set; }
    
    Guid TournamentId { get; set; }
}