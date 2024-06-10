using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class TrainingCenter
{
    public IUnit Train(UnitCategory unitCategory)
    {
        IWeapon? weapon;
        ITransportation? transportation;

        if (unitCategory == UnitCategory.Military)
        {
            weapon = new Stick();
            transportation = new Legs();
        }
        else
        {
            weapon = new Bow();
            transportation = new Legs();
        }

        return new Unit(weapon, transportation);
    }
}