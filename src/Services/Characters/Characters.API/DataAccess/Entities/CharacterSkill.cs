namespace Characters.API.DataAccess.Entities;

/// <summary>
/// Contains character specific data with each skill
/// </summary>
public class CharacterSkill
{
    /// <summary>
    /// A reference to the skill
    /// </summary>
    public Skill? Skill { get; set; }

    /// <summary>
    /// The id of the skill
    /// </summary>
    public int SkillId { get; set; } = 0;

    /// <summary>
    /// The character's experience in the skill
    /// </summary>
    public int Experience { get; set; } = 0;

}
