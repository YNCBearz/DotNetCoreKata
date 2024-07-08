using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class ArcherEquipmentFactory: IEquipmentFactory
{
    public IWeapon CreateWeapon()
    {
        return new Bow();  
    } 
    public ITransportation CreateTransportation() 
    {
        return new Legs();
    }
}