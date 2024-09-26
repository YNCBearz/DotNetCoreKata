namespace DotNetCoreKata.DomainModels.ZooKeeper;

// Element
public class Lion: IFeedable
{
    public void FeedBy(IFeeder feeder)
    {
        feeder.Feed(this);
    }
}