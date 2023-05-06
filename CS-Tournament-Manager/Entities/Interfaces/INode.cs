namespace CS_Tournament_Manager.Entities.Interfaces;

/// <summary>
/// Represents a physical or virtual machine that can be used to host game servers.
/// </summary>
public interface INode : INamedEntity
{
    /// <summary>
    /// IP Address of the node.
    /// </summary>
    string IpAddress { get; set; }
    /// <summary>
    /// SSH Port to connect to the node.
    /// </summary>
    int Port { get; set; }
    /// <summary>
    /// Username to connect to the node.
    /// </summary>
    string Username { get; set; }
    /// <summary>
    /// Password to connect to the node.
    /// </summary>
    string? Password { get; set; }
    /// <summary>
    /// SSH Key to connect to the node.
    /// </summary>
    string? SshKey { get; set; }
}