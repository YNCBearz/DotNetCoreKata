using DotNetCoreKata.DomainModels.ZooKeeper;

namespace DotNetCoreKata.Services.ZooKeeper;

public class Zoo
{
    public void FeedAnimals()
    {
        List<IFeedable> animals =
        [
            new Monkey(),
            new Cow(),
            new Lion()
        ];

        var feeder = new Feeder();

        foreach (var animal in animals)
        {
            animal.FeedBy(feeder);
        }
    }
}