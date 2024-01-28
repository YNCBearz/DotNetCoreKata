using DotNetCoreKata.ApiControllers;

namespace DotNetCoreKata.Tests.UnitTests.Attributes;

public class GlobalExceptionHandler(RequestDelegate next, ILogger<GlobalExceptionHandler> logger)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (FormatException exception)
        {
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status400BadRequest;

            await context.Response.WriteAsync(exception.Message);
        }
        catch (Exception exception)
        {
            logger.LogError(exception, nameof(GlobalExceptionHandler));
            
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            await context.Response.WriteAsync("Something went wrong");
        }
    }
}