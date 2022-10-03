using Characters.API.Business;
using Characters.API.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Characters.API.Controllers;

/// <summary>
/// The controller for characters
/// </summary>
[Route("api/characters")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly CharacterService _characterService;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="characterService">The character service</param>
    public CharactersController(CharacterService characterService)
    {
        _characterService = characterService;
    }

    /// <summary>
    /// Gets a character
    /// TODO: Currently creates a character instead of retrieving one
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public async Task<ActionResult<Character>> GetCharacter()
    {
        await Task.CompletedTask;
        return Ok(_characterService.CreateCharacter("Test"));
    }
}
