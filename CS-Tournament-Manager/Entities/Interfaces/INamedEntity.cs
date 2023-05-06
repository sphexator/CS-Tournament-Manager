namespace CS_Tournament_Manager.Entities.Interfaces;

public interface INamedEntity : IEntity
{
    string Name { get; set; }
}