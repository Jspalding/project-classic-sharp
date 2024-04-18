public class DiceRolls
{
    /// <summary>
    ///Roll a dice, choose dice size (d20 etc), how many rolls, and any modifiers
    /// </summary>
    public static List<int> RollDice(int diceSize, int rollsCount, int modifier, bool isAttributeRoll)
    {
        Random dice = new Random();

        List<int> rolls = new List<int>();

        for (int i = 0; i < rollsCount; i++)
        {
            var roll = dice.Next(1, diceSize);

            if (modifier == 0 || modifier == -1)
            {
                rolls.Add(roll);

                if (!isAttributeRoll)
                {
                    Console.WriteLine($"You rolled {roll}!");
                }
            }
            else
            {
                var modifiedRoll = roll + modifier;
                rolls.Add(modifiedRoll);

                if (!isAttributeRoll)
                {
                    Console.WriteLine($"You rolled {modifiedRoll} ({roll} + {modifier} modifier)!");
                }
            }
        }

        return rolls;
    }

    //Roll 4x D6 and total the 3 highest values
    public static int RollAttribute(int modifier)
    {
        List<int> rolls = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            rolls.Add(RollDice(6, 1, modifier, true).First());
        }

        int total = rolls.Sum() - rolls.Min();
        return total;
    }
}
