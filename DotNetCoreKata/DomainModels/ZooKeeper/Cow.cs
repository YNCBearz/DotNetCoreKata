namespace DotNetCoreKata.DomainModels.ZooKeeper;

// Element
public class Cow: IFeedable
{
    public void FeedBy(IFeeder feeder)
    {
        feeder.Feed(this);
    }
}