namespace DotNetCoreKata.DomainModels.ZooKeeper;

// Element
public class Monkey : IFeedable
{
    public void FeedBy(IFeeder feeder)
    {
        feeder.Feed(this);
    }
}