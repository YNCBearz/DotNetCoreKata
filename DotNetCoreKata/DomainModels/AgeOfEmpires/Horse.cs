namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class Horse : ITransportation
{
    public string Mode()
    {
        return "horse";
    }
}