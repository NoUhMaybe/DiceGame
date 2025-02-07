public class Dice
{
    private readonly Random _random = new Random();
    public const int NumberOfSides = 6;

    public int Roll() => _random.Next(1, NumberOfSides + 1);
}
