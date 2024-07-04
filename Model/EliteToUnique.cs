using System.ComponentModel.DataAnnotations;

namespace pixy;

public class EliteToUnique
{
    [Key]
    public int PrestigeId { get; set; }
    public int EliteOneId { get; set; }
    public int EliteTwoId { get; set; }
    public int ResultUniqueId { get; set; }
}