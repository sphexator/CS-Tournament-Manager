using CS_Tournament_Manager.Entities.Interfaces;

namespace CS_Tournament_Manager.Entities;

public class Player : IPlayer
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string SteamId { get; set; }
}