public class Menu
{
    string MenuTitle;
    private string[] MenuItems;
    private int SelectedIndex = 0;

    public Menu(string menuTitle, string[] menuItems)
    {
        MenuTitle = menuTitle;
        MenuItems = menuItems;
        SelectedIndex = 0;
    }

    private void CreateMenu()
    {
        Console.WriteLine($"{MenuTitle}");
        for (int i = 0; i < MenuItems.Length; i++)
        {
            string currentSelection = MenuItems[i];
            string selected = "";

            if (SelectedIndex == i)
            {
                selected = ">";
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.WriteLine($"{selected}{currentSelection}");
        }

        Console.ResetColor();
    }


    public int NavigateMenu()
    {
        ConsoleKey keyPressed = ConsoleKey.None;

        do
        {
            Console.CursorVisible = false;
            Console.Clear();
            CreateMenu();

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            keyPressed = consoleKeyInfo.Key;

            if (consoleKeyInfo.Key == ConsoleKey.DownArrow)
            {
                SelectedIndex++;

                if (SelectedIndex == MenuItems.Length)
                {
                    SelectedIndex = 0;
                }
            }

            else if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            {
                SelectedIndex--;

                if (SelectedIndex == -1)
                {
                    SelectedIndex = MenuItems.Length - 1;
                }

            }

        } while (keyPressed != ConsoleKey.Enter);

        Console.CursorVisible = true;
        return SelectedIndex;
    }

}


