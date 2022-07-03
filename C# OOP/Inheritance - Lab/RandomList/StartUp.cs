using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
        //    var customList = new RandomList<string>();
        //    customList.Add("Az");
        //    customList.Add("ti");
        //    customList.Add("toi");
        //    customList.Add("tya");
        //    customList.Add("te");
        //    customList.Add("nie");
        //    customList.Add("vie");
        //    customList.Add("te");
        //    customList.RandomString();

        //    foreach (var item in customList)
        //    {
        //        Console.WriteLine(item);
        //    }

            var list = new RandomList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.RandomString();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
