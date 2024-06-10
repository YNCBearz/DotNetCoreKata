namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public static class Stable
{
    public static Unit Create()
    {
        return new Unit(new Sword(), new Horse());
    }
}