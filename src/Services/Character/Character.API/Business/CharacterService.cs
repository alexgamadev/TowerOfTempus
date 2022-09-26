namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;

public class CharacterService : ICharacterService
{
    public Character CreateCharacter(string name)
    {
        var character = new Character()
        {
            Name = name,
            Experience = 0
        };

        return character;
    }
}
