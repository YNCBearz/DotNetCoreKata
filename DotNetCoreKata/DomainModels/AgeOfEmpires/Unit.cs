using DotNetCoreKata.Tests.UnitTests.Services.AgeOfEmpires;

namespace DotNetCoreKata.DomainModels.AgeOfEmpires;

public class Unit(IWeapon weapon, IMovement movement) : IUnit
{
    public string Attack()
    {
        return $"attacks with {weapon.Name()}";
    }
    
    public string Move()
    {
        return $"moves using {movement.Name()}";
    }
}