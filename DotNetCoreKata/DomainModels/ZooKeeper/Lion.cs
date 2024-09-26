namespace DotNetCoreKata.DomainModels.ZooKeeper;

public class Lion: IFeedable
{
    public void Feed()
    {
        Console.WriteLine("Lion eats meat");
    }
}