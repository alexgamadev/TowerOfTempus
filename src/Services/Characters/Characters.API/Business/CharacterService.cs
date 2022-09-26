namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;

/// <summary>
/// Handles basic character related functionality
/// </summary>
public class CharacterService : ICharacterService
{
    /// <summary>
    /// Creates a basic character
    /// </summary>
    /// <param name="name">The name of the character</param>
    /// <returns>A new character</returns>
    public Character CreateCharacter(string name)
    {
        var character = new Character()
        {
            Name = name,
            TotalExperience = 0,
            MaximumHealth = 100,
            Health = 100
        };

        return character;
    }
}
