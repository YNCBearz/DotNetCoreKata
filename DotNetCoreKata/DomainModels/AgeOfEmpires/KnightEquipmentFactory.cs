using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class KnightEquipmentFactory : IEquipmentFactory
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