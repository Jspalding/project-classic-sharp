using System.Reflection;

public class Helpers
{
    public static void CheckEmptyUserInput(Character character, string propertyName)
    {
        PropertyInfo propertyInfo = typeof(Character).GetProperty(propertyName);

        if (propertyInfo != null)
        {
            string propertyValue = (string)propertyInfo.GetValue(character);

            while (string.IsNullOrEmpty(propertyValue))
            {
                Console.WriteLine($"Please enter a {propertyName}");
                string userInput = Console.ReadLine();

                //Update the property value with user input
                propertyInfo.SetValue(character, userInput);

                // Update the propertyValue variable for next iteration
                propertyValue = userInput;

                if (!string.IsNullOrEmpty(userInput))
                {
                    break;
                }
            }
        }
        else
        {
            Console.WriteLine($"Property {propertyName} not found in Character class.");
        }
    }
}
