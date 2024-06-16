using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetCoreKata.Attributes;

[Obsolete("The framework will convert a string to an enum when you use an enum type.", false)]
public class ValidateEnumAttribute<TEnum>(string routeKeyName) : ActionFilterAttribute where TEnum : struct, Enum
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var key = (string) context.RouteData.Values[routeKeyName]!;

        if (!Enum.TryParse<TEnum>(key, true, out _))
        {
            throw new FormatException($"{routeKeyName} does not exist.");
        }

        await next();
    }
}