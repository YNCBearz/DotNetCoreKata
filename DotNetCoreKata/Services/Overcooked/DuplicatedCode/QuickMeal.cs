using DotNetCoreKata.DomainModels.Overcooked.DuplicatedCode;

namespace DotNetCoreKata.Services.Overcooked.DuplicatedCode;

public class QuickMeal
{
    public EggFriedRice PrepareForEggFriedRice()
    {
        var egg = new Egg();
        var rawRice = new RawRice();

        var firedEgg = egg.Fry();
        var rice = rawRice.Cook();

        return new EggFriedRice(firedEgg, rice);
    }

    public PorkCutletRice PrepareForPorkCutletRice()
    {
        var egg = new Egg();
        var rawRice = new RawRice();
        var pork = new Pork();

        var firedEgg = egg.Fry();
        var rice = rawRice.Cook();
        var porkCutlet = pork.Fry();
        
        return new PorkCutletRice(firedEgg, rice, porkCutlet);
    }
}