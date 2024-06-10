using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Program
{
    public IUnit Train(UnitCategory unitCategory)
    {
        var militia = new Unit(new Stick(), new Legs());
        var archer = new Unit(new Bow(), new Legs());
        var knight = new Unit(new Sword(), new Horse());

        return unitCategory switch
        {
            UnitCategory.Military => militia,
            UnitCategory.Archer => archer,
            UnitCategory.Knight => knight,
            _ => militia
        };
    }
}