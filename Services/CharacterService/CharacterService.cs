using System.Net;
using Microsoft.AspNetCore.Server.HttpSys;

namespace DotNet7_Web_Course.Services.CharacterService;

public class CharacterService: ICharacterService 
{
    
    private static List<Character> _characters = new List<Character>
    {
        new Character{},
        new Character{Name = "Donald", Class = Rpg.Cleric},
        new Character{Name = "Anna", Class = Rpg.Mage}
    };
    
    public List<Character> GetAllCharacters()
    {
        return _characters ;
    }

    public Character GetCharacterById(int id)
    {
        var character = _characters.FirstOrDefault(c => c.Id == id);
        if (character is not null)
            return character;
        throw new BadHttpRequestException("Character Not Found");
    }

    public List<Character> AddCharacter(Character character)
    {
        _characters.Add(character);
        return _characters ;
    }
}