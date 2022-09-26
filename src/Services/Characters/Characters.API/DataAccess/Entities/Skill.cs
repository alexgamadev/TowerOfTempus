namespace Characters.API.DataAccess.Entities;

/// <summary>
/// The database model for a single skill
/// </summary>
public class Skill
{
    /// <summary>
    /// Skill ID
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// The name of the skill
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// A description of the skill
    /// </summary>
    public string Description { get; set; } = String.Empty;

    /// <summary>
    /// The current experience for the skill
    /// </summary>
    public int Experience { get; set; } = 0;
}
