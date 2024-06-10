namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public static class ArcheryRange
{
    public static Unit Create()
    {
        return new Unit(new Bow(), new Legs());
    }
}