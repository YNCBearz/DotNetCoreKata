namespace DotNetCoreKata.DomainModels.ZooKeeper;

public class Monkey : IFeedable
{
    public void Feed()
    {
        Console.WriteLine("Monkey eats banana");
    }
}