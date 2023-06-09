﻿namespace CS_Tournament_Manager.Entities.Interfaces;

/// <summary>
/// Team entity for the tournament.
/// </summary>
public interface ITeam : INamedEntity
{
    /// <summary>
    /// Time the team was created.
    /// </summary>
    DateTimeOffset CreatedAt { get; set; }
    /// <summary>
    /// Whether the team is in captain mode or majority vote.
    /// True if captain mode, false if majority vote.
    /// </summary>
    bool CaptainMode { get; set; }
    /// <summary>
    /// Captain of the team.
    /// Null if captain mode is false.
    /// </summary>
    Player? Captain { get; set; }
    /// <summary>
    /// List of players in the team.
    /// </summary>
    List<Player> Players { get; set; }
    
    Guid TournamentId { get; set; }
}