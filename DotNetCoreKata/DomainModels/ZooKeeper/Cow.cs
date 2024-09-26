namespace DotNetCoreKata.DomainModels.ZooKeeper;

public class Cow: IFeedable
{
    public void Feed()
    {
        Console.WriteLine("Cow eats grass");
    }
}