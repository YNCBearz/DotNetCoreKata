using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class MilitiaEquipmentFactoryFactory : IEquipmentFactory
{
    public ITransportation CreateTransportation()
    {
        return new Legs();
    }

    public IWeapon CreateWeapon()
    {
        return new Stick();
    }
}