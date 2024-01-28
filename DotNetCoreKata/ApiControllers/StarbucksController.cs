using DotNetCoreKata.DomainModels.Starbucks;
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
            Drinks =
            [
                "Latte",
                "Mocha",
                "White"
            ]
        });
    }
}