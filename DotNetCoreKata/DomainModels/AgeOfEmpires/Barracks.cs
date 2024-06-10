namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public static class Barracks
{
    public static Unit Create()
    {
        return new Unit(new Stick(), new Legs());
    }
}