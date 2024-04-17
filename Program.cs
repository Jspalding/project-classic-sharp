
class DnDSimulator
{
    static void Main()
    {
        Character newCharacter = new Character();

        CreateCharacter.CreateNewCharacter(newCharacter);

        Console.WriteLine("**************************************************");
        Console.WriteLine("Character successfully created!");
        Console.WriteLine("**************************************************");

        Console.WriteLine($"Your character's name is {newCharacter.FirstName} {newCharacter.LastName}.");
        Console.WriteLine($"Your character's selected race is {newCharacter.CharacterRace.Race}.");
        Console.WriteLine($"Your character's selected class is {newCharacter.CharacterClass.MainClass}.");
        Console.WriteLine("**************************************************");
        Console.WriteLine("Your character's attributes are:");
        Console.WriteLine($"Strength: {newCharacter.CharacterAttributes.Strength}");
        Console.WriteLine($"Dexterity: {newCharacter.CharacterAttributes.Dexterity}");
        Console.WriteLine($"Constitution: {newCharacter.CharacterAttributes.Constitution}");
        Console.WriteLine($"Intelligence: {newCharacter.CharacterAttributes.Intelligence}");
        Console.WriteLine($"Wisdom: {newCharacter.CharacterAttributes.Wisdom}");
        Console.WriteLine($"Charisma: {newCharacter.CharacterAttributes.Charisma}");
        Console.WriteLine("**************************************************");
    }
}