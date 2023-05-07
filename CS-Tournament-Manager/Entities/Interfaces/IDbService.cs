using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Entities.Interfaces;

public interface IDbService
{
    DbSet<Tournament> Tournaments { get; set; }
    DbSet<Team> Teams { get; set; }
    DbSet<Player> Players { get; set; }
    DbSet<Match> Matches { get; set; }

    /// <summary>
    /// Saves changes in current context
    /// </summary>
    /// <returns></returns>
    Task<int> SaveChangesAsync(CancellationToken ctx = default);

    /// <summary>
    /// Checks if the database is created
    /// </summary>
    /// <returns></returns>
    Task<bool> EnsureDatabaseCreated(CancellationToken ctx = default);

    /// <summary>
    /// Migrates pending migrations to the database
    /// </summary>
    /// <returns></returns>
    Task MigrateDatabase(CancellationToken ctx = default);
}