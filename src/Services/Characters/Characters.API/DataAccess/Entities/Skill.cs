namespace Characters.API.DataAccess.Entities;

public class Skill
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Description { get; set; } = String.Empty;
    public int Experience { get; set; } = 0;
}
