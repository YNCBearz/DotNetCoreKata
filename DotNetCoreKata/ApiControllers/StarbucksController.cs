using DotNetCoreKata.Attributes;
using DotNetCoreKata.DomainModels.Starbucks;
using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreKata.ApiControllers;

[Route("api/starbucks")]
public class StarbucksController: ControllerBase
{
    [HttpGet("menus")]
    public IActionResult? GetMenu()
    {
        return ApiResponse.SuccessWithData(new Menu
        {
            Coffee =
            [
                "Latte",
                "Mocha",
                "White"
            ],
            Tea =
            [
                "Black Tea",
                "Earl Grey Tea",
                "Oolong Tea",
            ]
        });
    }

    [HttpGet("menus/{category}")]
    [ValidateEnum<MenuCategory>("category")]
    public IActionResult? GetMenuByCategory(MenuCategory category)
    {
        var data = MenuFactory.GenerateMenuByCategory(category);

        return ApiResponse.SuccessWithData(data);
    }
}