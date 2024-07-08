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
            UnitCategory.Military => new MilitiaEquipmentFactoryFactory(),
            UnitCategory.Archer => new ArcherEquipmentFactoryFactory(),
            UnitCategory.Knight => new KnightEquipmentFactoryFactory(),
            _ => new MilitiaEquipmentFactoryFactory()
        };

        return new Unit(equipmentFactoryFactory.CreateWeapon(), equipmentFactoryFactory.CreateTransportation());
    }
}