using DotNetCoreKata.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using NSubstitute;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Attributes;

[TestFixture]
public class ValidateMenuCategoryAttributeTests
{
    private ValidateMenuCategoryAttribute _validateMenuCategoryAttribute = null!;
    private HttpContext _httpContext = null!;

    [SetUp]
    public void SetUp()
    {
        _validateMenuCategoryAttribute = new ValidateMenuCategoryAttribute();
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

        Assert.That(async () => await _validateMenuCategoryAttribute.OnActionExecutionAsync(context, Next),
            Throws.TypeOf<FormatException>()
                .With.Message.EqualTo("category not exists"));
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