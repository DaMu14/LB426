using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacherMuellerLB_426
{
    public class Game
    {
        public Jetons jetons;

        public Game() 
        {
            Console.WriteLine("How many jetons do you want o buy?");
            int boughtjetons = Convert.ToInt32(Console.ReadLine());

            jetons = new Jetons(boughtjetons);

            Console.WriteLine("Craps (1), Slotmachine (2)?");

            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("Welcome  in the Craps game");

                PlayCraps();
            }

            else if (input == "2")
            {
                Console.WriteLine("Welcome in Slotmachine game");

                PlaySlotmachine();
            }
        }

        public void PlayCraps() 
        {
            Craps craps = new Craps();

            int result = craps.FirstRoll();

            if (result == 1)
            {
                Console.WriteLine("Congratulations! You win!");
                jetons.AddJetons(1);
            }
            else if (result == -1)
            {
                Console.WriteLine("Sorry, you lose!");
                jetons.AddJetons(-1);
            }
            else
            {
                Console.WriteLine("Point is set to: " + craps.point);
                while (true)
                {
                    int rollResult = craps.RollDice();
                    Console.WriteLine("You rolled: " + rollResult);
                    result = craps.SecondRoll();
                    if (result == 1)
                    {
                        Console.WriteLine("Congratulations! You win!");
                        jetons.AddJetons(1);
                        break;
                    }
                    else if (result == -1)
                    {
                        Console.WriteLine("Sorry, you lose!");
                        jetons.AddJetons(-1);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Roll again...");
                    }
                }
            }
            Console.WriteLine("Jetons: " + jetons.AddJetons(0.8));
        }

        public void PlaySlotmachine() 
        {
            Slotmachine slotmachine = new Slotmachine();
            Console.WriteLine("Jetons: " + jetons.AddJetons(slotmachine.SpinSlotmachine()));
        }
    }
}
