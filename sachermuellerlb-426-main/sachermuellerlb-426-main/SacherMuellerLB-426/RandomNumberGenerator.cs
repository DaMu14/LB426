namespace SacherMuellerLB_426
{
    public sealed class RandomNumberGenerator
    {
        private static readonly Lazy<RandomNumberGenerator> _lazy = new Lazy<RandomNumberGenerator>(() => new RandomNumberGenerator());
        private readonly Random _random;

        private RandomNumberGenerator()
        {
            _random = new Random();
        }

        public static RandomNumberGenerator Instance => _lazy.Value;

        public int GenerateRandomNumberSlotmachine()
        {
            return _random.Next(0, 12);
        }

        public int GenerateRandomNumberCraps()
        {
            return _random.Next(0, 6);
        }
    }
}

