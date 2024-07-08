using DotNetCoreKata.DomainModels;
using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Client : IClient
{
    public IUnit Train(UnitCategory unitCategory)
    {
        Console.Write($"Ask resources to build unit: {unitCategory}.");

        IEquipmentFactory equipmentFactoryFactory = unitCategory switch
        {
            UnitCategory.Military => new MilitiaEquipmentFactory(),
            UnitCategory.Archer => new ArcherEquipmentFactory(),
            UnitCategory.Knight => new KnightEquipmentFactory(),
            _ => new MilitiaEquipmentFactory()
        };

        return new Unit(equipmentFactoryFactory.CreateWeapon(), equipmentFactoryFactory.CreateTransportation());
    }
}