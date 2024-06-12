using DotNetCoreKata.Attributes;
using DotNetCoreKata.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NSubstitute;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace DotNetCoreKata.Tests.UnitTests.Attributes;

[TestFixture]
public class ValidateEnumAttributeTests
{
    private HttpContext _httpContext = null!;
    private ValidateEnumAttribute<MenuCategory> _validateEnumAttribute;

    [SetUp]
    public void SetUp()
    {
        _validateEnumAttribute = new ValidateEnumAttribute<MenuCategory>("category");
        _httpContext = Substitute.For<HttpContext>();
    }

    [TestCase("cake")]
    [TestCase("cookie")]
    public void not_in_menu_category(object? notExistCategory)
    {
        var context = new ActionExecutingContext(
            new ActionContext(
                httpContext: _httpContext,
                routeData: new RouteData(new RouteValueDictionary()
                {
                    {"category", notExistCategory}
                }),
                actionDescriptor: new ControllerActionDescriptor(),
                modelState: new ModelStateDictionary()
            ),
            new List<IFilterMetadata>(),
            new Dictionary<string, object>()!,
            Substitute.For<Controller>());

        Assert.That(async () => await _validateEnumAttribute.OnActionExecutionAsync(context, Next),
            Throws.TypeOf<FormatException>()
                .With.Message.EqualTo("category does not exist."));
    }

    [TestCase("Coffee")]
    public async Task in_menu_category(object? category)
    {
        var context = new ActionExecutingContext(
            new ActionContext(
                httpContext: _httpContext,
                routeData: new RouteData(new RouteValueDictionary()
                {
                    {"category", category}
                }),
                actionDescriptor: new ControllerActionDescriptor(),
                modelState: new ModelStateDictionary()
            ),
            new List<IFilterMetadata>(),
            new Dictionary<string, object>()!,
            Substitute.For<Controller>());

        await _validateEnumAttribute.OnActionExecutionAsync(context, Next);
        
        Assert.That(context.Result, Is.Null);
    }

    private Task<ActionExecutedContext> Next()
    {
        return Task.FromResult(new ActionExecutedContext(
            new ActionContext(
                httpContext: _httpContext,
                routeData: new RouteData(),
                actionDescriptor: new ControllerActionDescriptor(),
                modelState: new ModelStateDictionary()
            ),
            new List<IFilterMetadata>(),
            Substitute.For<Controller>()
        ));
    }

}