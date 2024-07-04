using System.ComponentModel.DataAnnotations;

namespace pixy;

public class EpicToHero
{
    [Key]
    public int PrestigeId { get; set; }
    public int EpicOneId { get; set; }
    public int EpicTwoId { get; set; }
    public int ResultHeroId { get; set; }
}