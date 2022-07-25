namespace Gym.Models.Athletes
{
    class Boxer : Athlete
    {
        private const int DefaultStamina = 60;

        public Boxer(string fullName, string motivation, int numberOfMedals) 
            : base(fullName, motivation, numberOfMedals, DefaultStamina)
        {
        }

        public override void Exercise()
        {
            this.Stamina += 15;
        }
    }
}
