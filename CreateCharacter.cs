
public class CreateCharacter
{
    public static Character CreateNewCharacter(Character character)
    {
        CharacterRace characterRace = new CharacterRace();
        CharacterClass characterClass = new CharacterClass();
        Attributes characterAttributes = new Attributes();

        Console.Clear();
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

        characterAttributes = CreateAttributeSelectTypeMenu(characterAttributes);
        character.CharacterAttributes = characterAttributes;

        return character;
    }

    private static string CreateRaceSelectMenu(CharacterRace characterRace)
    {
        List<string> raceMenuItems = characterRace.Races;
        string menuTitle = "Select your character's race:";
        int selectedIndex = 0;

        Menu mainMenu = new(menuTitle, raceMenuItems);
        selectedIndex = mainMenu.NavigateMenu();

        switch (selectedIndex)
        {
            case 0:
                return raceMenuItems[0];

            case 1:
                return raceMenuItems[1];

            case 2:
                return raceMenuItems[2];
            default:
                return "";
        }
    }

    private static CharacterRace SelectCharacterRace()
    {
        CharacterRace characterRace = new CharacterRace();
        string selectedRace = "";

        selectedRace = CreateRaceSelectMenu(characterRace);

        //Capture selected race
        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Are you sure you want to be an {selectedRace}? (y/n)");
            string confirmChoice = Console.ReadLine();

            if (confirmChoice == "y" || confirmChoice == "Y")
            {
                Console.WriteLine($"You have selected {selectedRace} as your character's race. ");
                characterRace.Race = selectedRace;
                break;
            }
            else
            {
                CreateRaceSelectMenu(characterRace);
            }
        }
        //TODO
        //Add character sub race select
        return characterRace;
    }

    private static string CreateClassSelectMenu(CharacterClass characterClass)
    {
        List<string> classMenuItems = characterClass.Classes;
        string menuTitle = "Select your character's class:";
        int selectedIndex = 0;

        Menu mainMenu = new(menuTitle, classMenuItems);
        selectedIndex = mainMenu.NavigateMenu();

        switch (selectedIndex)
        {
            case 0:
                return classMenuItems[0];

            case 1:
                return classMenuItems[1];

            case 2:
                return classMenuItems[2];
            default:
                return "";
        }
    }


    private static CharacterClass SelectCharacterClass()
    {
        CharacterClass characterClass = new CharacterClass();
        string selectedClass = "";

        selectedClass = CreateClassSelectMenu(characterClass);

        while (true)
        {
            Console.WriteLine("\n");
            Console.WriteLine($"Are you sure you want to be an {selectedClass}? (y/n)");
            string confirmChoice = Console.ReadLine();

            if (confirmChoice == "y" || confirmChoice == "Y")
            {
                Console.WriteLine($"You have selected {selectedClass} as your character's class. ");
                characterClass.MainClass = selectedClass;
                break;
            }
            else
            {
                CreateClassSelectMenu(characterClass);
            }

        }

        //TODO
        //Add character sub class select
        return characterClass;
    }

    private static Attributes CreateAttributeSelectTypeMenu(Attributes newCharacterAttributes)
    {
        List<string> menuItems = ["Input stats", "Roll stats (4d6 method)"];
        string menuTitle = "Please select how you would like to setup the attributes for this character:";
        int selectedIndex = 0;

        Menu mainMenu = new(menuTitle, menuItems);
        selectedIndex = mainMenu.NavigateMenu();

        switch (selectedIndex)
        {
            case 0:
                return InputCharacterAttributes(newCharacterAttributes);

            case 1:
                return RollCharacterAttributes(newCharacterAttributes);

            default:
                return RollCharacterAttributes(newCharacterAttributes);
        }
    }

    private static Attributes InputCharacterAttributes(Attributes newCharacterAttributes)
    {
        Console.WriteLine("Hello");
        return newCharacterAttributes;
    }

    private static Attributes RollCharacterAttributes(Attributes newCharacterAttributes)
    {
        Console.Clear();

        Console.WriteLine("Rolling for character stats using standard 5E roll rules...");
        Thread.Sleep(300);

        newCharacterAttributes = new Attributes
        {
            Strength = DiceRolls.RollAttribute(0),
            Dexterity = DiceRolls.RollAttribute(0),
            Constitution = DiceRolls.RollAttribute(0),
            Intelligence = DiceRolls.RollAttribute(0),
            Wisdom = DiceRolls.RollAttribute(0),
            Charisma = DiceRolls.RollAttribute(0)
        };

        Console.WriteLine($"Strength: {newCharacterAttributes.Strength}");
        Thread.Sleep(300);
        Console.WriteLine($"Dexterity: {newCharacterAttributes.Dexterity}");
        Thread.Sleep(300);
        Console.WriteLine($"Constitution: {newCharacterAttributes.Constitution}");
        Thread.Sleep(300);
        Console.WriteLine($"Intelligence: {newCharacterAttributes.Intelligence}");
        Thread.Sleep(300);
        Console.WriteLine($"Wisdom: {newCharacterAttributes.Wisdom}");
        Thread.Sleep(300);
        Console.WriteLine($"Charisma: {newCharacterAttributes.Charisma}");
        Thread.Sleep(300);

        return newCharacterAttributes;
    }

    private static Attributes AssignStandardArrayAttributes()
    {
        Attributes characterAttributes = new Attributes();

        List<int> standardArrayAttributes = new List<int> {
            8, 10, 12, 13, 14, 15
        };

        Console.WriteLine("Starting standard array process");
        Console.WriteLine("Choose one of 8, 10, 12, 13, 14, 15 to assign to an attribute.");
        Thread.Sleep(300);
        Console.WriteLine("Strength:");
        // assignValue = Console.ReadLine();
        // int x = int.TryParse(assignValue, out characterAttributes.Strength);

        return characterAttributes;

    }
}