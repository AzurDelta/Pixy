using System.Xml;
using Newtonsoft.Json;
using pixy.Interfaces;

namespace pixy.Service;

public class CrewService : ICrewService
{
    private ICrewRepository _repository;

    public CrewService(ICrewRepository repository)
    {
        _repository = repository;
    }

    public async Task UpdateCrewDBAsync(string xmlString)
    {
        XmlDocument doc = new XmlDocument();
        doc.LoadXml(xmlString);
        var jsonString = JsonConvert.SerializeXmlNode(doc);
        var trimLen = jsonString.Split('[')[0].Length;
        jsonString = jsonString.Substring(trimLen, jsonString.Length - 4 - trimLen)
            .Replace("DamageToSameRoomCharacters", "Газ")
            .Replace("HealRoomHp", "Срочный ремонт")
            .Replace("HealSelfHp", "Первая помощь")
            .Replace("AddReload", "Ускорение")
            .Replace("FireWalk", "Огненная походка")
            .Replace("DamageToCurrentEnemy", "Критический удар")
            .Replace("DamageToRoom", "Ультра-демонтаж")
            .Replace("DeductReload", "Взлом системы")
            .Replace("HealSameRoomCharacters", "Целительный дождь")
            .Replace("Freeze", "Крио-удар")
            .Replace("SetFire", "Поджог");
        var jObj = JsonConvert.DeserializeObject<List<CrewMember>>(jsonString);
        await _repository.SaveCrewListAsync(jObj);
    }

    public async Task FlushPrestigeList()
    {
        await _repository.FlushPrestigeList();
    }

    public async Task UpdatePrestigeDBAsync(string xmlString)
    {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xmlString);
            var jsonString = JsonConvert.SerializeXmlNode(doc);
            var trimLen = 0;
            if (jsonString.Length > 115)
            {
                trimLen = jsonString.Split('[')[0].Length;
                jsonString = jsonString.Substring(trimLen, jsonString.Length - trimLen);
                jsonString = jsonString.Substring(0, jsonString.Length - 4);
                await _repository.SavePrestigeDBAsync(JsonConvert.DeserializeObject<List<Prestige>>(jsonString));
            }
    }

    public async Task ParseToCategories()
    {
        await _repository.ParseToCategories();
    }
    
    public Task<int> GetMaxIDAsync()
    {
        return _repository.GetMaxIDAsync();
    }
}