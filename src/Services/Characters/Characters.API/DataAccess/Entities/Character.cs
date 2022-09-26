namespace Characters.API.DataAccess.Entities;

/// <summary>
/// Database model for the character
/// </summary>
public class Character
{
    /// <summary>
    /// Character ID
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Character name
    /// </summary>
    public string Name { get; set; } = String.Empty;

    /// <summary>
    /// Current total experience for the character
    /// </summary>
    public int TotalExperience { get; set; } = 0;

    /// <summary>
    /// Current character health
    /// </summary>
    public int Health { get; set; } = 0;

    /// <summary>
    /// The maximum health for the character
    /// </summary>
    public int MaximumHealth { get; set; } = 0;

    /// <summary>
    /// A list of the characters skills
    /// </summary>
    public List<Skill> Skills { get; set; } = new List<Skill>();
}
