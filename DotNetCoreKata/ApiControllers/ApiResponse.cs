using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreKata.ApiControllers;

public static class ApiResponse
{
    public static OkObjectResult? SuccessWithData(object data)
    {
        var response = new
        {
            Data = data
        };
        
        return new OkObjectResult(response)
        {
            ContentTypes = ["application/json"]
        };
    }
}