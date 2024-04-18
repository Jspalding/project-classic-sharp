
class DnDTableTop
{
    static void Main()
    {
        Character newCharacter = new Character();

        string titleArt = @"
  ____    ___    ____    _____   _     ____   _      _____  _____  ___   ____  
 |  _ \  ( _ )  |  _ \  |_   _| / \   | __ ) | |    | ____||_   _|/ _ \ |  _ \ 
 | | | | / _ \/\| | | |   | |  / _ \  |  _ \ | |    |  _|    | | | | | || |_) |
 | |_| || (_>  <| |_| |   | | / ___ \ | |_) || |___ | |___   | | | |_| ||  __/ 
 |____/  \___/\/|____/    |_|/_/   \_\|____/ |_____||_____|  |_|  \___/ |_|    
";

        Console.WriteLine(titleArt);

        CreateCharacter.CreateNewCharacter(newCharacter);

        //TODO: 
        // Add this page to own method (characterComplete, move to CreateCharacter)
        // Add confirm for stat
        // Add confirm for race/class selects
        // Add Main menu
        // Add race/class modifiers
        // Add sub races/classes
        // Add backgrounds and modifiers

        Console.WriteLine("\n");
        Console.WriteLine("**************************************************");
        Console.WriteLine("Character successfully created!");
        Console.WriteLine("**************************************************");
        Console.WriteLine("\n");
        Console.WriteLine($"Your character's name is {newCharacter.Name}");
        Console.WriteLine($"Your character's selected race is {newCharacter.CharacterRace.Race}.");
        Console.WriteLine($"Your character's selected class is {newCharacter.CharacterClass.MainClass}.");
        Console.WriteLine("\n");
        Console.WriteLine("Your character's attributes are:");
        Console.WriteLine("**************************************************");
        Console.WriteLine($"Strength: {newCharacter.CharacterAttributes.Strength}");
        Console.WriteLine($"Dexterity: {newCharacter.CharacterAttributes.Dexterity}");
        Console.WriteLine($"Constitution: {newCharacter.CharacterAttributes.Constitution}");
        Console.WriteLine($"Intelligence: {newCharacter.CharacterAttributes.Intelligence}");
        Console.WriteLine($"Wisdom: {newCharacter.CharacterAttributes.Wisdom}");
        Console.WriteLine($"Charisma: {newCharacter.CharacterAttributes.Charisma}");
        Console.WriteLine("**************************************************");
    }
}