using Characters.API.DataAccess.Entities;

namespace Characters.API.DataAccess.Services;

/// <summary>
/// The interface for the characters repository
/// </summary>
public interface ICharactersRepository
{
    /// <summary>
    /// Creates the character for the repository
    /// </summary>
    /// <param name="newCharacter">The new character data</param>
    /// <returns>An awaitable task</returns>
    Task CreateCharacterAsync(Character newCharacter);

    /// <summary>
    /// Gets a list of all characters
    /// </summary>
    /// <returns>The list of characters</returns>
    Task<IEnumerable<Character>> GetAllCharactersAsync();

    /// <summary>
    /// Checks whether a character already exists with the same name
    /// </summary>
    /// <param name="name">The name to check</param>
    /// <returns>Whether the character name already exists or not</returns>
    bool DoesCharacterNameExist(string name);
}
