using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;

namespace DotNetCoreKata.Services.AgeOfEmpires;

public class Program
{
    public IUnit Train(UnitCategory unitCategory)
    {
        return TrainingCenter.Create(unitCategory);
    }
}