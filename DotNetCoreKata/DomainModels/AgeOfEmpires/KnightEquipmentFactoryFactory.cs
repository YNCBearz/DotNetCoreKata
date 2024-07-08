using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class KnightEquipmentFactoryFactory : IEquipmentFactory
{
    public ITransportation CreateTransportation()
    {
        return new Horse();
    }

    public IWeapon CreateWeapon()
    {
        return new Sword();
    }
}