using Microsoft.AspNetCore.Mvc;

namespace DotNet7_Web_Course.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class CharacterController : ControllerBase

{
    private readonly ICharacterService _characterService;
    
    public CharacterController(ICharacterService characterService)
    {
        _characterService = characterService;
    }
    

    [HttpGet("{id}")]
    public ActionResult<Character> Get(int id)
    {
        try
        {
            return Ok(_characterService.GetCharacterById(id));
        }
        catch
        {
            return BadRequest("Character Not Found");
        }
    }
    
    [HttpGet("All")]
    public ActionResult<List<Character>> GetListCharacters()
    {
        return Ok(_characterService.GetAllCharacters()) ;
    }
    
    [HttpPost]
    public ActionResult<List<Character>> AddNew(Character newCharacter)
    {
        return Ok(_characterService.AddCharacter(newCharacter)) ;
    }
    
}