using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace pixy;

public class CrewMember
{
    [JsonProperty("@CharacterHeadPartId")]
    public int CharacterHeadPartId { get; set; }

    [JsonProperty("@CharacterBodyPartId")]
    public int CharacterBodyPartId { get; set; }
    
    [JsonProperty("@CharacterLegPartId")]
    public int CharacterLegPartId { get; set; }
    [Key]
    [JsonProperty("@CharacterDesignId")]
    public int Id { get; set; }

    [JsonProperty("@Rarity")]
    public string Rarity { get; set; }

    [JsonProperty("@SpecialAbilityType")]
    public string SpecialAbilityType { get; set; }

    [JsonProperty("@CollectionDesignId")]
    public int CollectionDesignId { get; set; }

    [JsonProperty("@EquipmentMask")]
    public int EquipmentMask { get; set; }

    [JsonProperty("@CharacterDesignName")]
    public string Name { get; set; }

    [JsonProperty("@CharacterDesignDescription")]
    public string CharacterDesignDescription { get; set; }

    [JsonProperty("@Hp")]
    public int Hp { get; set; }

    [JsonProperty("@FinalHp")]
    public int FinalHp { get; set; }

    [JsonProperty("@Attack")]
    public double BaseAttack { get; set; }

    [JsonProperty("@FinalAttack")]
    public double FinalAttack { get; set; }

    [JsonProperty("@Repair")]
    public double BaseRepair { get; set; }

    [JsonProperty("@FinalRepair")]
    public double FinalRepair { get; set; }

    [JsonProperty("@SpecialAbilityArgument")]
    public double SpecialAbilityBaseArgument { get; set; }

    [JsonProperty("@SpecialAbilityFinalArgument")]
    public double SpecialAbilityFinalArgument { get; set; }

    [JsonProperty("@Pilot")]
    public double BasePilot { get; set; }

    [JsonProperty("@FinalPilot")]
    public double FinalPilot { get; set; }
    
    [JsonProperty("@Science")]
    public double BaseScience { get; set; }

    [JsonProperty("@FinalScience")]
    public double FinalScience { get; set; }

    [JsonProperty("@Weapon")]
    public double BaseWeapon { get; set; }

    [JsonProperty("@FinalWeapon")]
    public double FinalWeapon { get; set; }

    [JsonProperty("@Engine")]
    public double BaseEngine { get; set; }

    [JsonProperty("@FinalEngine")]
    public double FinalEngine { get; set; }

    [JsonProperty("@WalkingSpeed")]
    public int WalkingSpeed { get; set; }

    [JsonProperty("@RunSpeed")]
    public int RunSpeed { get; set; }

    [JsonProperty("@FireResistance")]
    public int FireResistance { get; set; }

    [JsonProperty("@TrainingCapacity")]
    public int TrainingCapacity { get; set; }

}