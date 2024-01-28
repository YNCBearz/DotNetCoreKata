using DotNetCoreKata.ApiControllers;
using DotNetCoreKata.DomainModels.Starbucks;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.ApiControllers;

[TestFixture]
public class StarbucksControllerTests
{
    private IActionResult? _response;
    private StarbucksController _starbucksController = null!;

    [SetUp]
    public void SetUp()
    {
        _starbucksController = new StarbucksController();
    }

    [Test]
    public void Menus()
    {
        _response = _starbucksController.GetMenu();

        ResponseShouldBe(new Menu()
        {
            Coffee =
            [
                "Latte",
                "Mocha",
                "White",
            ],
            Tea = [
                "Black Tea",
                "Earl Grey Tea",
                "Oolong Tea",
            ]
        });
    }
    
    [Test]
    public void Coffee_Menus()
    {
        _response = _starbucksController.GetMenuByCategory(MenuCategory.Coffee);

        ResponseShouldBe(new List<string>()
        {
                "Latte",
                "Mocha",
                "White",
        });
    }

    private void ResponseShouldBe(object data)
    {
        var result = _response.As<OkObjectResult>();
        result.StatusCode.Should().Be(200);

        result.Value.Should().BeEquivalentTo(new
        {
            Data = data
        });
    }
}