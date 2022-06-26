namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            DarkKnight test = new DarkKnight("Knight", 2);
            SoulMaster master = new SoulMaster("Master", 10);


            System.Console.WriteLine(test);
            System.Console.WriteLine(master);
        }
    }
}