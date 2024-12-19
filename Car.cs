namespace Day08
{
    public class Car : IWalkable
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped");
        }
    }
}
