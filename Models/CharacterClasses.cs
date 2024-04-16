public enum Classes
{
    //Barbarian,
    // Bard,
    // Cleric,
    // Druid,
    Fighter,
    // Monk,
    // Paladin,
    // Ranger,
    Rogue,
    // Sorceror,
    // Warlock,
    Wizard
}

public class CharacterClass
{
    public Classes MainClass { get; set; }
    public string? SubClass { get; set; }
}