namespace DotNetCoreKata.DomainModels.ZooKeeper;

public interface IFeedable
{
    void FeedBy(IFeeder feeder);
}