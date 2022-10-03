using Characters.API.DataAccess.Entities;

namespace Characters.API.Business;

/// <summary>
/// The interface for the service handling skill related functionality
/// </summary>
public interface ISkillService
{
    /// <summary>
    /// Gets the current level of a skill
    /// </summary>
    /// <param name="characterId">The id of the character</param>
    /// <param name="skillId">The id of the skill</param>
    /// <returns>The skill level</returns>
    public int GetSkillLevel(Guid characterId, int skillId);

    /// <summary>
    /// Adds experience to a skill
    /// </summary>
    /// <param name="characterId">The id of the character</param>
    /// <param name="skillId">The id of the skill</param>
    /// <param name="experienceToAdd">The amount of experience to add</param>
    public void AddSkillExperience(Guid characterId, int skillId, int experienceToAdd);

    /// <summary>
    /// Get the amount of experience for the skill
    /// </summary>
    /// <param name="characterId">The id of the character</param>
    /// <param name="skillId">The id of the skill</param>
    /// <returns>The skill experience</returns>
    public int GetSkillExperience(Guid characterId, int skillId);

    /// <summary>
    /// Gets a skill
    /// </summary>
    /// <param name="skillId">The id of the skill</param>
    /// <returns>Data about the skill</returns>
    public Skill? GetSkill(int skillId);

    /// <summary>
    /// Gets all skills
    /// </summary>
    /// <returns>A list of skills</returns>
    public IEnumerable<Skill> GetAllSkills();

    /// <summary>
    /// Gets data about a skill for a character
    /// </summary>
    /// <param name="characterId">The id of the character</param>
    /// <param name="skillId">The id of the skill</param>
    /// <returns>Data about the character's skill</returns>
    public CharacterSkill GetSkill(Guid characterId, int skillId);
}
