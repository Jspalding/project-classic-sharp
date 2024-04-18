public class Character
{
    public string Name { get; set; }
    public CharacterRace CharacterRace { get; set; }
    public CharacterClass CharacterClass { get; set; }
    public Attributes CharacterAttributes { get; set; }
}

public class Attributes
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Constitution { get; set; }
    public int Intelligence { get; set; }
    public int Wisdom { get; set; }
    public int Charisma { get; set; }
}

