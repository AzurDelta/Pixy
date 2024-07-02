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
}