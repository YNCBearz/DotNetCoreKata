using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class MilitiaEquipmentFactory : IEquipment
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