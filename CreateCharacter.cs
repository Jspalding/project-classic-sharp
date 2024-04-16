
public class CreateCharacter
{
    public static Character CreateNewCharacter(Character character)
    {
        Console.WriteLine("What is your character's first name?");
        character.FirstName = Console.ReadLine();
        Helpers.CheckEmptyUserInput(character, "FirstName");

        Console.WriteLine("What is your character's last name?");
        character.LastName = Console.ReadLine();
        Helpers.CheckEmptyUserInput(character, "LastName");

        SelectCharacterRace();

        return character;
    }

    private static CharacterRace SelectCharacterRace()
    {
        CharacterRace characterRace = new CharacterRace();
        List<Races> races = new List<Races>();
        int raceOptionNumber = 1;

        foreach (Races race in Enum.GetValues(typeof(Races)))
        {
            races.Add(race);
        }

        Console.WriteLine("Select your character's race:");
        foreach (var race in races)
        {
            Console.WriteLine($"{raceOptionNumber}. {race}");
            raceOptionNumber++;
        }


        return characterRace;
    }
}