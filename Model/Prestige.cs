using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace pixy;

public class Prestige
{
    [Key]
    public int PrestigeID { get; set; }
    
    [JsonProperty("@CharacterDesignId1")]
    public int MemberOneId { get; set; }
    
    [JsonProperty("@CharacterDesignId2")]
    public int MemberTwoId { get; set; }
    
    [JsonProperty("@ToCharacterDesignId")]
    public int ResultMemberId { get; set; }
    
    public double? PrestigeValue { get; set; }
}