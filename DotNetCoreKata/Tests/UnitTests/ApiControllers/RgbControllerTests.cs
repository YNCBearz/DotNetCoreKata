using DotNetCoreKata.ApiControllers;
using DotNetCoreKata.Enums;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.ApiControllers;

[TestFixture]
public class RgbControllerTests
{
    private RgbController _rgbController;

    [SetUp]
    public void SetUp()
    {
        _rgbController = new RgbController();
    }

    [Test]
    public void black_screen()
    {
        var color = _rgbController.Display();
        color.Should().Be(Color.Black);
    }

    [Test]
    public void red_light()
    {
        _rgbController.TurnOnLight(Color.Red);
        var color = _rgbController.Display();
        color.Should().Be(Color.Red);
    }

    [Test]
    public void green_light()
    {
        _rgbController.TurnOnLight(Color.Green);
        var color = _rgbController.Display();
        color.Should().Be(Color.Green);
    }

    [Test]
    public void blue_light()
    {
        _rgbController.TurnOnLight(Color.Blue);
        var color = _rgbController.Display();
        color.Should().Be(Color.Blue);
    }

    [Test]
    public void red_and_green()
    {
        _rgbController.TurnOnLight(Color.Red);
        _rgbController.TurnOnLight(Color.Green);
        var color = _rgbController.Display();
        color.Should().Be(Color.Yellow);
    }

    [Test]
    public void red_and_blue()
    {
        _rgbController.TurnOnLight(Color.Red);
        _rgbController.TurnOnLight(Color.Blue);
        var color = _rgbController.Display();
        color.Should().Be(Color.Violet);
    }

    [Test]
    public void green_and_blue()
    {
        _rgbController.TurnOnLight(Color.Green);
        _rgbController.TurnOnLight(Color.Blue);
        var color = _rgbController.Display();
        color.Should().Be(Color.Cyan);
    }

    [Test]
    public void red_and_green_and_blue()
    {
        _rgbController.TurnOnLight(Color.Red);
        _rgbController.TurnOnLight(Color.Green);
        _rgbController.TurnOnLight(Color.Blue);
        var color = _rgbController.Display();
        color.Should().Be(Color.White);
    }
}