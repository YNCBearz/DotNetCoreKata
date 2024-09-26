namespace DotNetCoreKata.DomainModels.ZooKeeper;

public interface IFeeder
{
    void Feed(Monkey monkey);
    void Feed(Cow cow);
    void Feed(Lion lion);
}