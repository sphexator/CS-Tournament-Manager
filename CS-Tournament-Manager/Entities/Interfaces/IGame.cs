namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IGame : IMap
{
    int TeamOneScore { get; set; }
    int TeamTwoScore { get; set; }
    
    Guid MatchId { get; set; }
    Match Match { get; set; }
}