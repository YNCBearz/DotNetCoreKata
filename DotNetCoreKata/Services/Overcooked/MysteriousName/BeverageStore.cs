namespace DotNetCoreKata.Services.Overcooked.MysteriousName;

public class BeverageStore
{
    public Drink Get(string n, string s, string i)
    {
        var drink = new Drink();

        if (n == "qqneineidrinkabletomeiputea")
        {
            drink.SetContent("BubbleTea");
        }
        else
        {
            drink.SetContent("Coke");
        }
        
        drink.SetSugar(s);
        drink.SetIce(i);

        return drink;
    }   
}