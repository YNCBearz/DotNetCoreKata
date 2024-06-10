using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels;

public interface IEquipment
{
    IWeapon CreateWeapon();
    ITransportation CreateTransportation();
}