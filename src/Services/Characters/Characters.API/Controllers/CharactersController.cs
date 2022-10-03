using Characters.API.Business;
using Characters.API.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Characters.API.Controllers;
[Route("api/characters")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly CharacterService _characterService;

    public CharactersController(CharacterService characterService)
    {
        _characterService = characterService;
    }

    [HttpGet]
    public async Task<ActionResult<Character>> GetCharacter()
    {
        await Task.CompletedTask;
        return Ok(_characterService.CreateCharacter("Test"));
    }
}
