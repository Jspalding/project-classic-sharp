
class DnDTableTop
{
    static void Main()
    {
        string titleArt = @"
  ____    ___    ____    _____   _     ____   _      _____  _____  ___   ____  
 |  _ \  ( _ )  |  _ \  |_   _| / \   | __ ) | |    | ____||_   _|/ _ \ |  _ \ 
 | | | | / _ \/\| | | |   | |  / _ \  |  _ \ | |    |  _|    | | | | | || |_) |
 | |_| || (_>  <| |_| |   | | / ___ \ | |_) || |___ | |___   | | | |_| ||  __/ 
 |____/  \___/\/|____/    |_|/_/   \_\|____/ |_____||_____|  |_|  \___/ |_|    
";

        Console.WriteLine(titleArt);

        Character newCharacter = new Character();

        CreateCharacter.CreateNewCharacter(newCharacter);
        CharacterSummary.DisplayCharacterSummary(newCharacter);

        //TODO: 
        // Add this page to own method (characterComplete, move to CreateCharacter)
        // Add confirm for stat
        // Add confirm for race/class selects
        // Add Main menu
        // Add race/class modifiers
        // Add sub races/classes
        // Add backgrounds and modifiers
    }
}