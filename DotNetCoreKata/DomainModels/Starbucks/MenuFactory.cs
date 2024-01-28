using DotNetCoreKata.Enums;

namespace DotNetCoreKata.DomainModels.Starbucks;

public static class MenuFactory
{
    public static List<string> GenerateMenuByCategory(MenuCategory category)
    {
        var data = new List<string>();

        switch (category)
        {
            case MenuCategory.Coffee:
                data.Add("Latte");
                data.Add("Mocha");
                data.Add("White");
                break;
            case MenuCategory.Tea:
                data.Add("Black Tea");
                data.Add("Earl Grey Tea");
                data.Add("Oolong Tea");
                break;
        }

        return data;
    }
}