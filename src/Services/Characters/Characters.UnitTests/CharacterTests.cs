using Characters.API.Business;
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
        var characterService = new CharacterService();

        var character = characterService.CreateCharacter("Test");

        Assert.Equal("Test", character.Name);
    }

    [Fact]
    public void CharacterService_CreateCharacter_HealthShouldBeSameAsMax()
    {
        var characterService = new CharacterService();

        var character = characterService.CreateCharacter("Test");

        Assert.Equal(character.Health, character.MaximumHealth);
    }
}
