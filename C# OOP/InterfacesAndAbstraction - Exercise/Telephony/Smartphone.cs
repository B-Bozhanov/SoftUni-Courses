namespace Telephony
{
    internal class Smartphone : ISmartphone
    {
        public void Calling(string number)
        {
            System.Console.WriteLine($"Calling... {number}");
        }
        public void Browsing(string webSite)
        {
            System.Console.WriteLine($"Browsing: {webSite}!");
        }
    }
}
