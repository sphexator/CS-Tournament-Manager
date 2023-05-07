namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IMap : INamedEntity
{
    /// <summary>
    /// Map path to execute. Eg. de_dust2 instead of Dust2
    /// </summary>
    string Path { get; set; }
}