public enum Classes
{
    //Barbarian,
    // Bard,
    // Cleric,
    // Druid,
    Fighter = 1,
    // Monk,
    // Paladin,
    // Ranger,
    Rogue = 2,
    // Sorceror,
    // Warlock,
    Wizard = 3
}

public class CharacterClass
{
    public Classes MainClass { get; set; }
    public string? SubClass { get; set; }
}