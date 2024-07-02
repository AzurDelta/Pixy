using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using pixy.Interfaces;

namespace pixy;
[ApiController]
[Route("pixy")]
public class Pixycontroller : ControllerBase
{
    private ICrewService _service;
    
    public Pixycontroller(ICrewService service)
    {
        _service = service;
    }
    
    [HttpGet]
    public async Task<ActionResult> GetCrewList()
    {
            return Ok("<PrestigeCharacterFrom errorMessage=\"Cannot prestige legendary and special characters.\" />".Length);
    }
    
    
    
    
    [HttpGet]
    [Route("base/update/crew")]
    public async Task<IActionResult> GetCrewBaseUpToDate()
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync("http://api.pixelstarships.com/CharacterService/ListAllCharacterDesigns2?languageKey=ru&version=0.999.5");
            await _service.UpdateCrewDBAsync(await response.Content.ReadAsStringAsync());
            response.Dispose();
        }
        return Ok();
    }
    
    [HttpGet]
    [Route("base/update/prestige")]
    public async Task<IActionResult> GetPrestigeBaseUpToDate()
    {
        await _service.FlushPrestigeList();
        using (HttpClient client = new HttpClient())
        {
            var maxId = await _service.GetMaxIDAsync();
            for (int id = 1; id < maxId; id++)
            {
                HttpResponseMessage response = await client.GetAsync($"http://api.pixelstarships.com/CharacterService/PrestigeCharacterFrom?characterDesignId={id}");
                await _service.UpdatePrestigeDBAsync(await response.Content.ReadAsStringAsync());
                response.Dispose();
                Thread.Sleep(100);
            }

            
        }
        return Ok();
    }
}