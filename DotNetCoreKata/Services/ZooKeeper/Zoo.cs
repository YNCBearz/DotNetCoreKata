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

        foreach (var animal in animals)
        {
            animal.Feed();
        }
    }
}