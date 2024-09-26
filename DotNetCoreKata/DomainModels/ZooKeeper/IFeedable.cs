using DotNetCoreKata.Services.ZooKeeper;

namespace DotNetCoreKata.DomainModels.ZooKeeper;

public interface IFeedable
{
    void FeedBy(IFeeder feeder);
}