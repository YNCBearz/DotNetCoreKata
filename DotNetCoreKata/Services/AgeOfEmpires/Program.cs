using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Program
{
    public IUnit Train(UnitCategory unitCategory)
    {
        IWeapon? weapon;
        IMovement? movement;

        if (unitCategory == UnitCategory.Military)
        {
            weapon = new Stick();
            movement = new Legs();
        }
        else
        {
            weapon = new Bow();
            movement = new Legs();
        }

        return new Unit(weapon, movement);
    }
}