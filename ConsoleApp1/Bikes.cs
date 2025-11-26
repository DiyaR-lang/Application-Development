public class Bikes : Vehicle2
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}