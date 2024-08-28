using DotNetCoreKata.DomainModels.Overcooked.MysteriousName;

namespace DotNetCoreKata.Services.Overcooked.MysteriousName;

public class BeverageStore
{
    private const string BubbleTeaInMenu = "qqneineidrinkabletomeiputea";

    public Drink Order(string name, string sugarLevel, string iceLevel)
    {
        var drink = new Drink();

        if (name == BubbleTeaInMenu)
        {
            drink.Pour("BubbleTea");
        }
        else
        {
            drink.Pour("Coke");
        }

        drink.SetSugarLevel(sugarLevel);
        drink.AddIce(iceLevel);

        return drink;
    }   
}