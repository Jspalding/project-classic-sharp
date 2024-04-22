public class Menu(string menuTitle, List<string> menuItems)
{
    private int SelectedIndex = 0;

    private void CreateMenu()
    {
        Console.WriteLine($"{menuTitle}");
        for (int i = 0; i < menuItems.Count; i++)
        {
            string currentSelection = menuItems[i];
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

                if (SelectedIndex == menuItems.Count)
                {
                    SelectedIndex = 0;
                }
            }

            else if (consoleKeyInfo.Key == ConsoleKey.UpArrow)
            {
                SelectedIndex--;

                if (SelectedIndex == -1)
                {
                    SelectedIndex = menuItems.Count - 1;
                }

            }

        } while (keyPressed != ConsoleKey.Enter);

        Console.CursorVisible = true;
        return SelectedIndex;
    }

}


