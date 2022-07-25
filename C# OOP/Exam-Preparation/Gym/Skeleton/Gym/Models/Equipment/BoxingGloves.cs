namespace Gym.Models.Equipment
{
    public class BoxingGloves : Equipment
    {
        private const int DefaultWeights = 227;
        private const decimal DefaultPrice = 120;
        public BoxingGloves()
            : base(DefaultWeights, DefaultPrice)
        {
        }
    }
}
