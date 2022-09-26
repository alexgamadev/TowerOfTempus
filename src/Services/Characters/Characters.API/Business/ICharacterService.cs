namespace Characters.API.Business;

using Characters.API.DataAccess.Entities;

public interface ICharacterService
{
    Character CreateCharacter(string name);
}
