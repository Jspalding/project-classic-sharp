public enum Races
{
    Dragonborn,
    Dwarf,
    Elf,
    Gnome,
    Half_Elf,
    Halfling,
    Half_Orc,
    Human,
    Tiefling
}

public class CharacterRace
{
    public Races Races { get; set; }
    public string? Subrace { get; set; }
}