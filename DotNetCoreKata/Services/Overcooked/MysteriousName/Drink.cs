namespace DotNetCoreKata.Services.Overcooked.MysteriousName;

public class Drink
{
    private string _content = "Water";
    private string _sugar = "no sugar";
    private string _ice = "no ice";

    public void SetContent(string coke)
    {
        _content = coke;
    }

    public void SetSugar(string s)
    {
        _sugar = s;
    }

    public void SetIce(string i)
    {
        _ice = i;
    }
    
    public string GetContent()
    {
        return $"{_content}: {_sugar}, {_ice}";
    }
}