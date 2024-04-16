
public class CreateCharacter
{
    public static Character CreateNewCharacter(Character character)
    {
        CharacterRace characterRace = new CharacterRace();
        CharacterClass characterClass = new CharacterClass();
        Attributes characterAttributes = new Attributes();

        Console.WriteLine("What is your character's first name?");
        character.FirstName = Console.ReadLine();
        Helpers.CheckEmptyUserInput(character, "FirstName");

        Console.WriteLine("What is your character's last name?");
        character.LastName = Console.ReadLine();
        Helpers.CheckEmptyUserInput(character, "LastName");

        characterRace = SelectCharacterRace();
        character.CharacterRace = characterRace;

        characterClass = SelectCharacterClass();
        character.CharacterClass = characterClass;

        characterAttributes = RollCharacterAttributes();
        character.CharacterAttributes = characterAttributes;

        return character;
    }

    private static CharacterRace SelectCharacterRace()
    {
        CharacterRace characterRace = new CharacterRace();
        List<string> races = new List<string>();
        int raceOptionNumber = 1;

        //Map races enum to list
        foreach (Races race in Enum.GetValues(typeof(Races)))
        {
            races.Add(race.ToString());
        }

        Console.WriteLine("Select your character's race:");
        foreach (var race in races)
        {
            Console.WriteLine($"{raceOptionNumber}. {race}");
            raceOptionNumber++;
        }

        //Capture selected race
        while (true)
        {
            string selectedValue = Console.ReadLine();

            if (int.TryParse(selectedValue, out raceOptionNumber))
            {
                Races selectedRace = (Races)raceOptionNumber;
                Console.WriteLine($"You have selected {selectedRace} as your character's race. ");

                characterRace.Race = selectedRace;
                break;
            }
            else
            {
                Console.WriteLine("Please select an option by it's number.");
            }
        }

        //TODO
        //Add character sub race select
        return characterRace;
    }

    private static CharacterClass SelectCharacterClass()
    {
        CharacterClass characterClass = new CharacterClass();
        List<string> classes = new List<string>();
        int classOptionNumber = 1;

        //Map races enum to list
        foreach (Classes currentClass in Enum.GetValues(typeof(Classes)))
        {
            classes.Add(currentClass.ToString());
        }

        Console.WriteLine("Select your character's class:");
        foreach (var currentClass in classes)
        {
            Console.WriteLine($"{classOptionNumber}. {currentClass}");
            classOptionNumber++;
        }

        //Capture selected race
        while (true)
        {
            string selectedValue = Console.ReadLine();

            if (int.TryParse(selectedValue, out classOptionNumber))
            {
                Classes selectedClass = (Classes)classOptionNumber;
                Console.WriteLine($"You have selected {selectedClass} as your character's class. ");

                characterClass.MainClass = selectedClass;
                break;
            }
            else
            {
                Console.WriteLine("Please select an option by it's number.");
            }
        }

        //TODO
        //Add character sub class select
        return characterClass;
    }

    private static Attributes RollCharacterAttributes()
    {
        Console.WriteLine("Time to roll for character stats!");

        Attributes characterAttributes = new Attributes
        {
            Strength = DiceRolls.RollAttribute(0),
            Dexterity = DiceRolls.RollAttribute(0),
            Constitution = DiceRolls.RollAttribute(0),
            Intelligence = DiceRolls.RollAttribute(0),
            Wisdom = DiceRolls.RollAttribute(0),
            Charisma = DiceRolls.RollAttribute(0)
        };

        Console.WriteLine($"Strength: {characterAttributes.Strength}");
        Console.WriteLine($"Dexterity: {characterAttributes.Dexterity}");
        Console.WriteLine($"Constitution: {characterAttributes.Constitution}");
        Console.WriteLine($"Intelligence: {characterAttributes.Intelligence}");
        Console.WriteLine($"Wisdom: {characterAttributes.Wisdom}");
        Console.WriteLine($"Charisma: {characterAttributes.Charisma}");

        return characterAttributes;
    }
}