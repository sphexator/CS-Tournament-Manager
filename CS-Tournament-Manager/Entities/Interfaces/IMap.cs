namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IMap : INamedEntity
{
    /// <summary>
    /// Name of the map to execute. Eg. de_dust2 instead of Dust2
    /// </summary>
    string MapName { get; set; }
}