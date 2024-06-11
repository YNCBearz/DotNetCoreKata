using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreKata.ApiControllers;

[Route("api/age-of-empires")]
public class AgeOfEmpiresController(Services.AgeOfEmpires.Client client) : ControllerBase
{
    [HttpPost("unit/{unitCategory}")]
    public IActionResult? CreateUnit(UnitCategory unitCategory)
    {
        client.Train(unitCategory);
        return ApiResponse.SuccessWithData("");
    }
}