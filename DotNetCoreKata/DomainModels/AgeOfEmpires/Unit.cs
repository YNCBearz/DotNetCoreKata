using DotNetCoreKata.DomainModels.AgeOfEmpires.Transportation;
using DotNetCoreKata.DomainModels.AgeOfEmpires.Weapon;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class Unit(IWeapon weapon, ITransportation transportation) : IUnit
{
    public string Attack()
    {
        return $"attacks with {weapon.Name()}";
    }

    public string Move()
    {
        return $"moves using {transportation.Mode()}";
    }
}