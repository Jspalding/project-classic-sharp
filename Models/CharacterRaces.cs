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
    public string Race { get; set; }
    public List<string> Races = ["Dwarf", "Elf", "Human"];

    public string? Subrace { get; set; }
}