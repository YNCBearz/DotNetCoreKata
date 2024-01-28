using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetCoreKata.Attributes;

public class ValidateMenuCategoryAttribute : ActionFilterAttribute
{
    public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var category = context.RouteData.Values["category"];

        if (!Enum.TryParse<MenuCategory>((string?) category, out var menuCategory))
        {
            throw new FormatException("category not exists");
        }

        await next();
    }
}