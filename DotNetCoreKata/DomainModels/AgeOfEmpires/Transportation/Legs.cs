namespace DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;

public class Legs : ITransportation
{
    public string Mode()
    {
        return "legs";
    }
}