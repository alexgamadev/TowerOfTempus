using Characters.API.DataAccess.Entities;

namespace Characters.API.DataAccess.Services;

/// <summary>
/// A non-persistant testing repository using in memory storage
/// </summary>
public class InMemCharactersRepository : ICharactersRepository
{
    /// <summary>
    /// In memory list of characters
    /// </summary>
    public List<Character> _characters = new();

    /// <inheritdoc/>
    public async Task CreateCharacterAsync(Character newCharacter)
    {
        _characters.Add(newCharacter);
        await Task.CompletedTask;
    }

    /// <inheritdoc/>
    public bool DoesCharacterNameExist(string name)
    {
        var character = _characters.Find(c => c.Name == name);
        return character is not null;
    }

    /// <inheritdoc/>
    public async Task<IEnumerable<Character>> GetAllCharactersAsync()
    {
        await Task.CompletedTask;
        return _characters.ToList();
    }
}
