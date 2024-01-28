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
        return ApiResponse.SuccessWithData(new Menu()
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
    public IActionResult? GetMenuByCategory(MenuCategory category)
    {
        if (category == MenuCategory.Coffee)
        {
            return ApiResponse.SuccessWithData(
                new List<string>
                {
                    "Latte",
                    "Mocha",
                    "White",
                });
        }

        return ApiResponse.SuccessWithData(
            new List<string>
            {
                "Black Tea",
                "Earl Grey Tea",
                "Oolong Tea",
            });
    }
}