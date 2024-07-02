namespace pixy.Interfaces;

public interface ICrewService
{
    public Task UpdateCrewDBAsync(string responce);
    
    public Task FlushPrestigeList();
    
    public Task UpdatePrestigeDBAsync(string responce);
    
    
    public Task<int> GetMaxIDAsync();
}