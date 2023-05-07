using CS_Tournament_Manager.Entities;
using CS_Tournament_Manager.Entities.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Database;

public class DbService : DbContext, IDbService
{
    public DbService(DbContextOptions<DbService> options) : base(options) { }
    
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Match> Matches { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Tournament>(x =>
        {
            x.HasKey(e => e.Id);
            x.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        modelBuilder.Entity<Team>(x =>
        {
            x.HasKey(e => e.Id);
            x.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        modelBuilder.Entity<Player>(x =>
        {
            x.HasKey(e => e.Id);
            x.Property(e => e.Id).ValueGeneratedOnAdd();
        });
        modelBuilder.Entity<Match>(x =>
        {
            x.HasKey(e => e.Id);
            x.Property(e => e.Id).ValueGeneratedOnAdd();
        });
    }
    
    public async Task<int> SaveChangesAsync(CancellationToken ctx = default) 
        => await base.SaveChangesAsync(ctx);
    public async Task<bool> EnsureDatabaseCreated(CancellationToken ctx = default) 
        => await base.Database.EnsureCreatedAsync(ctx);
    public async Task MigrateDatabase(CancellationToken ctx = default) 
        => await base.Database.MigrateAsync(cancellationToken: ctx);
}