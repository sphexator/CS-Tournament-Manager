using CS_Tournament_Manager.Entities;
using Microsoft.EntityFrameworkCore;

namespace CS_Tournament_Manager.Database;

public class DbService : DbContext
{
    public DbSet<Tournament> Tournaments { get; set; }
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Match> Matches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        => base.OnConfiguring(optionsBuilder);

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
}