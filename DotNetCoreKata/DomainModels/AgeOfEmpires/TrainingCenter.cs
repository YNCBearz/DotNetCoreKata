using DotNetCoreKata.Enums;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public static class TrainingCenter
{
    public static IUnit Create(UnitCategory unitCategory)
    {
        return unitCategory switch
        {
            UnitCategory.Military => new Unit(new Stick(), new Legs()),
            UnitCategory.Archer => new Unit(new Bow(), new Legs()),
            UnitCategory.Knight => new Unit(new Sword(), new Horse()),
            _ => new Unit(new Stick(), new Legs())
        };
    }
}