namespace DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;

public class Horse : ITransportation
{
    public string Mode()
    {
        return "horse";
    }
}