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
            Drinks =
            [
                "Latte",
                "Mocha",
                "White",
            ]
        });
    }

    private void ResponseShouldBe(Menu menu)
    {
        var result = _response.As<OkObjectResult>();
        result.StatusCode.Should().Be(200);

        result.Value.Should().BeEquivalentTo(new
        {
            Data = menu
        });
    }
}