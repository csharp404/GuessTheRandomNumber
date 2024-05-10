// Yousef
// [05/10/2024]
//                  ___________
//                 /           \
//                 |  R.I.P.   |
//                 |   _____   |
//                 |  /     \  |
//                 | | () () | |
//                 |  \  ^  /  |
//                 |   |||||   |
//                 |   |||||   |
//                 |   |||||   |
//                 |   |||||   |
//                 |   |||||   |
//                 |___|||||___|
//                 \___|||||___/

internal class Program
{
    private static void Main(string[] args)
    {
        Random random = new Random();
        int ran = random.Next(1, 50);
        int guess = -1;

        do
        {
            Console.Write("The numbre you expect ? ");
            if (int.TryParse(Console.ReadLine(), out int guessed))
            {
                guess = guessed;
            }
            if (guessed > ran)
            {
                Console.WriteLine("The number is less than what you expected.");
            }
            else if (guessed < ran)
            {
                Console.WriteLine("The number is more than what you expected.");
            }
            if (guessed == ran)
            {
                Console.WriteLine("Congratulations, you guessed the number right!");
                break;
            }
        } while (guess != ran);

    }
}