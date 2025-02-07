class InputReader
{
    public static int IntReader(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();
            bool TryParse = int.TryParse(userInput, out int result);
            if (TryParse)
            {
                return result;
            }
        }
    }
    public static int IntReader(string message, int floor, int ceiling)
    {
        while (true)
        {
            Console.WriteLine(message);
            var userInput = Console.ReadLine();
            bool TryParse = int.TryParse(userInput, out int result);
            if (TryParse && result > floor - 1 && result < ceiling + 1)
            {
                return result;
            }
        }
    }
}