namespace DotNet7_Web_Course.Services.CharacterService;

public interface ICharacterService
{
    List<Character> GetAllCharacters();

    Character GetCharacterById(int id);

    List<Character> AddCharacter(Character character);
}