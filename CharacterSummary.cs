public class CharacterSummary
{

    public static void DisplayCharacterSummary(Character newCharacter)
    {
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
