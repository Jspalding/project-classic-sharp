﻿
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

        CreateMainMenu(titleArt);

        //TODO: 
        // Fix blinking weirdness on menu
        // Add menu to all other selects (race, class etc)
        // Look further into Spectre.Console
        // Add select stat roll type menu
        // Finish standard array method
        // Add race/class modifiers
        // Add sub races/classes
        // Add backgrounds and modifiers
    }

    private static void CreateMainMenu(string titleArt)
    {
        string[] mainMenuItems = ["Play", "Create", "Exit"];
        string mainMenuTitle = titleArt;
        int selectedIndex = 0;

        Menu mainMenu = new(mainMenuTitle, mainMenuItems);
        selectedIndex = mainMenu.NavigateMenu();

        switch (selectedIndex)
        {
            case 0:
                DisplayTabletop();
                break;

            case 1:
                DisplayCreateCharacter();
                break;

            case 2:
                Console.WriteLine("Farewell, adventurer.");
                Environment.Exit(0);
                break;

            default:
                Console.WriteLine("Farewell, adventurer.");
                Environment.Exit(0);
                break;
        }
    }

    private static void DisplayTabletop()
    {
        Console.WriteLine("Coming soon...");
        Environment.Exit(0);
    }

    private static void DisplayCreateCharacter()
    {
        Character character = new();
        CreateCharacter.CreateNewCharacter(character);
        CharacterSummary.DisplayCharacterSummary(character);
    }
}






