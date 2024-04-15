namespace Character.Models
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public Attributes CharacterAttributes { get; set; }
    }

    public class CharacterRace
    {
        public string Race { get; set; }
        public string? Subrace { get; set; }
    }

    public class CharacterClass
    {
        public string CharClass { get; set; }
        public string? SubClass { get; set; }
    }

    public class Attributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituation { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
