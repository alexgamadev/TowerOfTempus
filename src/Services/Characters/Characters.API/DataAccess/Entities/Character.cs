namespace Characters.API.DataAccess.Entities;
public class Character
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public int Experience { get; set; } = 0;
    public int Health { get; set; } = 0;
    public int MaximumHealth { get; set; } = 0;
    public List<Skill> Skills { get; set; } = new List<Skill>();
}
