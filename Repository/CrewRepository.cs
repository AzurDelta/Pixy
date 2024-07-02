using Microsoft.EntityFrameworkCore;
using pixy.Interfaces;

namespace pixy.Repository;

public class CrewRepository : ICrewRepository
{
    private Context _dbContext;

    public CrewRepository(Context dbContext)
    {
        _dbContext = dbContext;
    }
    
    public async Task SaveCrewListAsync(List<CrewMember> crewList)
    {
        foreach (var c in crewList)
        {
            _dbContext.CrewMembers.Add(c);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task FlushPrestigeList()
    {
        await _dbContext.SaveChangesAsync();
    }

    public async Task SavePrestigeDBAsync(List<Prestige> prestigeList)
    {
        _dbContext.Prestiges.AddRange(prestigeList);
        await _dbContext.SaveChangesAsync();
    }

    public async Task<int> GetMaxIDAsync()
    {
        return await _dbContext.CrewMembers.MaxAsync(c => c.Id);
    }
}