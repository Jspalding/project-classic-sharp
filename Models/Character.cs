namespace Character.Models
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CharacterClass { get; set; }
        public string CharacterRace { get; set; }
    }

    public class CharacterAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constituation { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
    }
}
