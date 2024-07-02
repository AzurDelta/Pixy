namespace pixy.Interfaces;

public interface ICrewRepository
{
    public Task SaveCrewListAsync(List<CrewMember> crewList);
    
    public Task FlushPrestigeList();
    
    public Task SavePrestigeDBAsync(List<Prestige> prestigeList);
    
    public Task<int> GetMaxIDAsync();
}