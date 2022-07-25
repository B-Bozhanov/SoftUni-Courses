namespace Gym.Models.Equipment
{
    public class Kettlebell : Equipment
    {
        private const int DefaultWeights = 10000;
        private const decimal DefaultPrice = 80;

        public Kettlebell()
            : base(DefaultWeights, DefaultPrice)
        {
        }
    }
}
