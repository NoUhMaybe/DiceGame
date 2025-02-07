
public class GameLogic
{
    public static void StartGame()
    {
        var num = new Dice().Roll();
        var guesses = 3;
        Console.WriteLine(GameOutput.GameStart);
        while (guesses > 0)
        {
            int guess = InputReader.IntReader(GameOutput.PromptUserForGuess, 1 , Dice.NumberOfSides);
            if (guess == num)
            {
                Console.WriteLine(GameOutput.WinMessage);
                return;
            }
            else
            {
                Console.WriteLine(GameOutput.LoseMessage);
                guesses--;
            }

        }
        Console.WriteLine(GameOutput.GameLost);
        Console.WriteLine($"Number was {num}");
        return;
    }
}