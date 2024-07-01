using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace pixy;
[ApiController]
[Route("pixy/crew")]
public class Pixycontroller : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> GetCrewList()
    {
        var url =
            "http://api.pixelstarships.com/CharacterService/ListAllCharacterDesigns2?languageKey=en&version=0.999.5";
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                string xmlString = await response.Content.ReadAsStringAsync();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlString);
                var jsonString = JsonConvert.SerializeXmlNode(doc);
                jsonString = jsonString.Replace("@","");
                return Ok(jsonString);
                
            }
            else
            {
                throw new Exception($"Ошибка запроса: {response.StatusCode}");
            }   
        }
    }
}