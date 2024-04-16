public class DiceRolls
{
    //Roll a dice, between 1 and specified dice size
    public static int RollDice(int diceSize, int modifier)
    {
        Random dice = new Random();
        int result = dice.Next(1, diceSize);

        if (modifier == 0 || modifier == -1)
        {
            return result;
        }
        else
        {
            return result + modifier;
        }
    }

    //Roll 4x D6 and total the 3 highest values
    public static int RollAttribute(int modifier)
    {
        List<int> rolls = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            rolls.Add(RollDice(6, modifier));
        }

        int total = rolls.Sum() - rolls.Min();
        return total;
    }
}
