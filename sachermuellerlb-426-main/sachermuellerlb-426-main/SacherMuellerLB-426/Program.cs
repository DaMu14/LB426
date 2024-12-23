namespace SacherMuellerLB_426
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            Console.WriteLine("Welcome in the Casino");

            while (playAgain)
            {
                Game game = new Game();

                Console.WriteLine("Play Again (y/n)?");

                if (Console.ReadLine() == "n")
                {
                    playAgain = false;
                }
            }
        }
    }
}
