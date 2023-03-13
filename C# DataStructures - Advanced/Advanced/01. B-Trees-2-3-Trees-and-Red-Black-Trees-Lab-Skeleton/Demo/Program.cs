using _01.Two_Three;

namespace Demo
{
    class Program
    {
        private enum Brade
        {
            Bulldog,
            Sambernar,
            Dackel,
            Puddel,
            Street
        }

        private class Dog
        {
            public Dog(string id, string name, Brade brade, int age, int vaccinies)
            {
                Id = id;
                Name = name;
                Brade = brade;
                Age = age;
                Vaccinies = vaccinies;
            }

            public string Id { get; }
            public string Name { get; }
            public Brade Brade { get; }
            public int Age { get; }
            public int Vaccinies { get; }
        }
        static void Main()
        {
            var tree = new TwoThreeTree<Dog>();

            tree.Insert(new Dog("1", "Bendji", Brade.Street, 4, 0));
            tree.Insert(new Dog("2", "Marley", Brade.Bulldog, 2, 1));
            tree.Insert(new Dog("3", "Rafi", Brade.Dackel, 5, 3));
            tree.Insert(new Dog("1", "Bendji", Brade.Street, 4, 0));

            System.Console.WriteLine();
        }              
    }
}
