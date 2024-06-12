using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetCoreKata.Attributes;

public class ValidateEnumAttribute<TEnum>(string routeKeyName) : ActionFilterAttribute where TEnum : struct, Enum
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var key = context.RouteData.Values[routeKeyName];

        if (!Enum.TryParse<TEnum>((string?) key, out var enumValue))
        {
            throw new FormatException($"{routeKeyName} does not exist.");
        }

        await next();
    }
}