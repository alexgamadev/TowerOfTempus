namespace Characters.API.Business;

/// <summary>
/// Interface for the leveling service
/// </summary>
public interface ILevelingService
{
    /// <summary>
    /// Checks the current level of a skill based on experience
    /// </summary>
    /// <returns>The level of the skill</returns>
    public int CheckLevel();
}
