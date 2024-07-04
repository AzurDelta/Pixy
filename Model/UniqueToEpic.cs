using System.ComponentModel.DataAnnotations;

namespace pixy;

public class UniqueToEpic
{
    [Key]
    public int PrestigeId { get; set; }
    public int UniqueOneId { get; set; }
    public int UniqueTwoId { get; set; }
    public int ResultEpicId { get; set; }
}