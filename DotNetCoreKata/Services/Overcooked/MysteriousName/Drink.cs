namespace DotNetCoreKata.Services.Overcooked.MysteriousName;

public class Drink
{
    private string _content = "Water";
    private string _sugarLevel = "no sugar";
    private string _iceLevel = "no ice";

    public void Pour(string content)
    {
        _content = content;
    }

    public void SetSugarLevel(string sugarLevel)
    {
        _sugarLevel = sugarLevel;
    }

    public void AddIce(string iceLevel)
    {
        _iceLevel = iceLevel;
    }
    
    public string GetDescription()
    {
        return $"{_content}: {_sugarLevel}, {_iceLevel}";
    }
}