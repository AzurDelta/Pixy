using System.ComponentModel.DataAnnotations;

namespace pixy;

public class HeroToLeg
{
    [Key]
    public int PrestigeId { get; set; }
    public int HeroOneID { get; set; }  
    public int HeroTwoID { get; set; }
    public int ResultLegID { get; set; }
}