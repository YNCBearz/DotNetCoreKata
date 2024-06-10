using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Program
{
    public IUnit Train(UnitCategory unitCategory)
    {
        return unitCategory switch
        {
            UnitCategory.Military => Barracks.Create(),
            UnitCategory.Archer => ArcheryRange.Create(),
            UnitCategory.Knight => Stable.Create(),
            _ => Barracks.Create()
        };
    }
}