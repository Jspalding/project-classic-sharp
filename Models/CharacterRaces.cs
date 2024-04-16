public enum Races
{
    //Dragonborn,
    Dwarf = 1,
    Elf = 2,
    //Gnome,
    //Half_Elf,
    //Halfling,
    //Half_Orc,
    Human = 3,
    //Tiefling
}

public class CharacterRace
{
    public Races Races { get; set; }
    public string? Subrace { get; set; }
}