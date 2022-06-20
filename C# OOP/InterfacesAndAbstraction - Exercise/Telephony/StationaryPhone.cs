namespace Telephony
{
    internal class StationaryPhone : IStationaryPhone
    {
        public void Dialing(string number)
        {
            System.Console.WriteLine($"Dialing... {number}");
        }
    }
}
