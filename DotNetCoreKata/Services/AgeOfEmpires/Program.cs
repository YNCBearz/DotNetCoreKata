using DotNetCoreKata.DomainModels;
using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Program
{
    public IUnit Train(UnitCategory unitCategory)
    {
        IEquipment equipmentFactory = unitCategory switch
        {
            UnitCategory.Military => new MilitiaEquipmentFactory(),
            UnitCategory.Archer => new ArcherEquipmentFactory(),
            UnitCategory.Knight => new KnightEquipmentFactory(),
            _ => new MilitiaEquipmentFactory()
        };

        return new Unit(equipmentFactory.CreateWeapon(), equipmentFactory.CreateTransportation());
    }
}