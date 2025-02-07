
public class GameLogic
{
    public static void StartGame()
    {
        var num = new Random().Next(1, 7);
        var guesses = 3;
        Console.WriteLine(GameOutput.GameStart);
        while (guesses > 0)
        {
            Console.WriteLine(GameOutput.PromptUserForGuess);
            string userInput = Console.ReadLine();
            bool TryParse = int.TryParse(userInput, out int guess);
            if (guess == num)
            {
                Console.WriteLine(GameOutput.WinMessage);
                return;
            }
            else if (!TryParse || num < 0 || num > 6)
            {
                continue;
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