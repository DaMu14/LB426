namespace SacherMuellerLB_426
{
    public class Slotmachine
    {
        private readonly List<string> _charactersList;
        private readonly RandomNumberGenerator randomNumber;
        private Dictionary<string, double> _winningCombinations;

        public Slotmachine()
        {
            _charactersList = new List<string>
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L"
            };

            randomNumber = RandomNumberGenerator.Instance;
            _winningCombinations = new Dictionary<string, double>
            {
                {"AAA", 10},
                {"BBB", 5},
                {"CCC", 2.5},
                {"DDD", 2.4},
                {"EEE", 2.3},
                {"FFF", 2.2},
                {"GGG", 2.1},
                {"HHH", 1.5},
                {"III", 1.4},
                {"JJJ", 1.3},
                {"KKK", 1.2},
                {"LLL", 1.1},
            };
        }

        public double SpinSlotmachine()
        {
            string[] results = new string[3];
            for (int i = 0; i < 3; i++)
            {
                int index = randomNumber.GenerateRandomNumberSlotmachine();

                results[i] = _charactersList[index];

                Console.Write(" " + results[i]);
                Thread.Sleep(1000);
            }

            Console.WriteLine();

            string combination = string.Join("", results);
            if (_winningCombinations.ContainsKey(combination))
            {
                Console.WriteLine($"Jetons * {_winningCombinations[combination]}");
                return _winningCombinations[combination];
            }
            else
            {
                return 0.8;
            }
        }
    }
}