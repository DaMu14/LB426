using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SacherMuellerLB_426
{
    public class Craps
    {
        private Random random;
        public int point { get; set; }

        public Craps()
        {
            random = new Random();
        }

        public int RollDice()
        {
            return random.Next(1, 7);
        }

        public int FirstRoll()
        {
            int total = RollDice() + RollDice();

            if (total == 7 || total == 11)
            {
                return 1;
            }
            else if (total == 2 || total == 3 || total == 12)
            {
                return -1;
            }
            else
            {
                point = total;
                return 0;
            }
        }

        public int SecondRoll()
        {
            int total = RollDice() + RollDice();

            if (total == point)
            {
                return 1;
            }
            else if (total == 7)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
