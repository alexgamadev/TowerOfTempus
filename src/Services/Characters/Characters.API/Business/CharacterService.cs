namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;

/// <summary>
/// Handles basic character related functionality
/// </summary>
public class CharacterService : ICharacterService
{
    /// <inheritdoc/>
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

    /// <inheritdoc/>
    public bool DoesCharacterNameExist(string name)
    {
        return true;
    }
}
