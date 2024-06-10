using DotNetCoreKata.Tests.UnitTests.Services.AgeOfEmpires;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class Legs : ITransportation
{
    public string Name()
    {
        return "legs";
    }
}