public class DiceRolls
{
    public int RollD20(int modifier)
    {
        Random dice = new Random();
        int result = dice.Next(0, 20);

        if (modifier == 0 || modifier == -1)
        {
            return result;
        }
        else
        {
            return result + modifier;
        }
    }
}
