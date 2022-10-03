namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;

/// <summary>
/// Interface for the character service
/// </summary>
public interface ICharacterService
{
    /// <summary>
    /// Creates a basic character
    /// </summary>
    /// <param name="name">The name of the character</param>
    /// <returns>A new character</returns>
    Character CreateCharacter(string name);

    /// <summary>
    /// Checks if a character name exists already
    /// </summary>
    /// <param name="name">The name to check</param>
    /// <returns>Whether the name exists already</returns>
    bool DoesCharacterNameExist(string name);
}
