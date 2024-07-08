using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels;

public interface IEquipmentFactory
{
    IWeapon CreateWeapon();
    ITransportation CreateTransportation();
}