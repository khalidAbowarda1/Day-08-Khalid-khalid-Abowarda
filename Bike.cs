namespace Day08
{
    public class Bike : IWalkable
    {
        public void StartEngine()
        {
            Console.WriteLine("Bike pedaling started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Bike pedaling stopped");
        }
    }
}
