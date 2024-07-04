using Microsoft.EntityFrameworkCore;

namespace pixy.Repository;

public class Context : DbContext
{
    public Context(DbContextOptions<Context> options) : base(options)
    {
        Database.EnsureCreated();
    }
    
    public DbSet<CrewMember> CrewMembers { get; set; }
    public DbSet<Prestige> Prestiges { get; set; }
    public DbSet<EliteToUnique> EliteToUniques { get; set; }
    public DbSet<UniqueToEpic> UniqueToEpics { get; set; }
    public DbSet<EpicToHero> EpicToHeroes { get; set; }
    public DbSet<HeroToLeg> HeroToLegs { get; set; }
    
}