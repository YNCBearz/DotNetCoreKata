namespace DotNetCoreKata.DomainModels.Overcooked.DuplicatedCode;

public class RawRice
{
    public Rice Cook()
    {
        return new Rice(this);
    }
}

public class Rice(RawRice rawRice)
{ }