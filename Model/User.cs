namespace pixy;

public class User
{
    public Guid UserId { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public List<CrewMember> CrewMembers { get; set; }
    public List<Prestige> Prestiges { get; set; }
}