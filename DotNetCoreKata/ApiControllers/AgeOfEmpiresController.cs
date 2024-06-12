using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreKata.ApiControllers;

[Route("api/age-of-empires")]
public class AgeOfEmpiresController(Services.AgeOfEmpires.IClient client) : ControllerBase
{
    [HttpPost("unit/{unitCategory}")]
    public IActionResult? CreateUnit(UnitCategory unitCategory)
    {
        var unit = client.Train(unitCategory);
        return ApiResponse.SuccessWithData(new
        {
            Move = unit.Move(),
            Attack = unit.Attack(),
        });
    }
}