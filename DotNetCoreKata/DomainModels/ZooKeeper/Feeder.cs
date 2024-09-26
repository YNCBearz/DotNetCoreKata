namespace DotNetCoreKata.DomainModels.ZooKeeper;

// Visitor
public class Feeder: IFeeder
{
    public void Feed(Monkey monkey)
    {
        Console.WriteLine("Monkey eats banana");
    }

    public void Feed(Cow cow)
    {
        Console.WriteLine("Cow eats grass");
    }

    public void Feed(Lion lion)
    {
        Console.WriteLine("Lion eats meat");
    }
}