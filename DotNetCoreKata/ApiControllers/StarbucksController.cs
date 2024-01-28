using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreKata.ApiControllers;

public class StarbucksController: ControllerBase
{
    [HttpGet("/aaa")]
    public IActionResult GetMenu()
    {
        return Ok();
    }
}