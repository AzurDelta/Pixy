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
        if (_dbContext.CrewMembers.First(c => c.Id == prestigeList.First().ResultMemberId).Rarity != "Elite")
        {
            _dbContext.Prestiges.AddRange(prestigeList);
            await _dbContext.SaveChangesAsync();
        }
    }

    public async Task<int> GetMaxIDAsync()
    {
        return await _dbContext.CrewMembers.MaxAsync(c => c.Id);
    }

    public async Task ParseToCategories()
    { 
        List<int> unique = await _dbContext.CrewMembers
            .Where(c => c.Rarity == "Unique")
            .Select(c => c.Id)
            .ToListAsync();
        
       unique.ForEach(u =>
       {
          _dbContext.Prestiges.Where(p => p.ResultMemberId == u)
              .ToList()
              .ForEach(p => 
           {
               _dbContext.EliteToUniques.Add(new EliteToUnique
               {
                   EliteOneId = p.MemberOneId,
                   EliteTwoId = p.MemberTwoId,
                   ResultUniqueId = p.ResultMemberId
               });
           });
       });
       
       await _dbContext.SaveChangesAsync();
    }
    
}