namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;
using Characters.API.DataAccess.Services;

/// <summary>
/// Handles basic character related functionality
/// </summary>
public class CharacterService : ICharacterService
{
    private readonly ICharactersRepository _charactersRepository;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="charactersRepository">The injected character repository</param>
    public CharacterService(ICharactersRepository charactersRepository)
    {
        _charactersRepository = charactersRepository;
    }

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

        _charactersRepository.CreateCharacterAsync(character);

        return character;
    }

    /// <inheritdoc/>
    public bool DoesCharacterNameExist(string name)
    {
        var doesExist = _charactersRepository.DoesCharacterNameExist(name);
        return doesExist;
    }
}
