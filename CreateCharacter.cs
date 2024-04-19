
public class CreateCharacter
{
    public static Character CreateNewCharacter(Character character)
    {
        CharacterRace characterRace = new CharacterRace();
        CharacterClass characterClass = new CharacterClass();
        Attributes characterAttributes = new Attributes();

        Console.WriteLine("\n");
        Console.WriteLine("****************************");
        Console.WriteLine("Creating a new character");
        Console.WriteLine("****************************");
        Console.WriteLine("What is your character's name?");
        character.Name = Console.ReadLine();
        Helpers.CheckEmptyUserInput(character, "Name");
        Console.WriteLine($"You named your character {character.Name}.");

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
        string confirmChoice = "";

        //Map races enum to list
        foreach (Races race in Enum.GetValues(typeof(Races)))
        {
            races.Add(race.ToString());
        }

        Console.WriteLine("\n");
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

                Console.WriteLine($"Are you sure you want to be an {selectedRace}? (y/n)");
                confirmChoice = Console.ReadLine();

                if (confirmChoice == "y" || confirmChoice == "Y")
                {
                    Console.WriteLine($"You have selected {selectedRace} as your character's race. ");
                    characterRace.Race = selectedRace;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Select your character's race:");
                    foreach (var race in races)
                    {
                        Console.WriteLine($"{raceOptionNumber}. {race}");
                        raceOptionNumber++;
                    }
                }
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
        string confirmChoice = "";

        //Map class enum to list
        foreach (Classes currentClass in Enum.GetValues(typeof(Classes)))
        {
            classes.Add(currentClass.ToString());
        }

        Console.WriteLine("\n");
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

                Console.WriteLine($"Are you sure you want to be an {selectedClass}? (y/n)");
                confirmChoice = Console.ReadLine();

                if (confirmChoice == "y" || confirmChoice == "Y")
                {
                    Console.WriteLine($"You have selected {selectedClass} as your character's class. ");
                    characterClass.MainClass = selectedClass;
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Select your character's class:");
                    foreach (var currentClass in classes)
                    {
                        Console.WriteLine($"{classOptionNumber}. {currentClass}");
                        classOptionNumber++;
                    }
                }
            }
        }

        //TODO
        //Add character sub class select
        return characterClass;
    }

    private static Attributes RollCharacterAttributes()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Rolling for character stats using standard roll rules...");
        Thread.Sleep(300);

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
        Thread.Sleep(300);
        Console.WriteLine($"Dexterity: {characterAttributes.Dexterity}");
        Thread.Sleep(300);
        Console.WriteLine($"Constitution: {characterAttributes.Constitution}");
        Thread.Sleep(300);
        Console.WriteLine($"Intelligence: {characterAttributes.Intelligence}");
        Thread.Sleep(300);
        Console.WriteLine($"Wisdom: {characterAttributes.Wisdom}");
        Thread.Sleep(300);
        Console.WriteLine($"Charisma: {characterAttributes.Charisma}");
        Thread.Sleep(300);

        return characterAttributes;
    }
}