using Characters.API.DataAccess.Entities;

namespace Characters.API.Business;

/// <summary>
/// The service handling skill related functionality
/// </summary>
public class SkillService : ISkillService
{
    /// <summary>
    /// A list of skills
    /// </summary>
    List<Skill> _skillList;

    /// <summary>
    /// Skill Service Constructor
    /// </summary>
    public SkillService()
    {
        _skillList = new List<Skill>()
        {
            new Skill() { Name = "Test Skill", Id = -1, Description = "A skill made for testing purposes" }
        };
    }

    /// <inheritdoc/>
    public void AddSkillExperience(Guid characterId, int skillId, int experienceToAdd)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Skill> GetAllSkills()
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public Skill? GetSkill(int skillId)
    {
        return _skillList.Find(x => x.Id == skillId);
    }

    /// <inheritdoc/>
    public CharacterSkill GetSkill(Guid characterId, int skillId)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int GetSkillExperience(Guid characterId, int skillId)
    {
        throw new NotImplementedException();
    }

    /// <inheritdoc/>
    public int GetSkillLevel(Guid characterId, int skillId)
    {
        throw new NotImplementedException();
    }
}
