using Characters.API.Business;
using Characters.API.DataAccess.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters.UnitTests;
public class CharacterTests
{
    [Fact]
    public void CharacterService_CreateCharacter_NameShouldMatch()
    {
        // Assert
        var charactersRepository = new InMemCharactersRepository();
        var characterService = new CharacterService(charactersRepository);

        // Arrange
        var character = characterService.CreateCharacter("Test");

        // Act
        Assert.Equal("Test", character.Name);
    }

    [Fact]
    public void CharacterService_CreateCharacter_HealthShouldBeSameAsMax()
    {
        // Assert
        var charactersRepository = new InMemCharactersRepository();
        var characterService = new CharacterService(charactersRepository);

        // Arrange
        var character = characterService.CreateCharacter("Test");

        // Act
        Assert.Equal(character.Health, character.MaximumHealth);
    }

    [Fact]
    public void CharacterService_DoesCharacterNameExist_ReturnsCorrectResult()
    {
        // Assert
        var charactersRepository = new InMemCharactersRepository();
        var characterService = new CharacterService(charactersRepository);

        // Act
        Assert.False(characterService.DoesCharacterNameExist("Test"));
    }

    [Fact]
    public void CharacterService_DoesCharacterNameExist_ReturnsTrueIfExists()
    {
        // Assert
        var charactersRepository = new InMemCharactersRepository();
        var characterService = new CharacterService(charactersRepository);

        // Arrange
        _ = characterService.CreateCharacter("Test");

        // Act
        Assert.True(characterService.DoesCharacterNameExist("Test"));
    }
}
