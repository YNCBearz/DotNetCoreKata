﻿using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.Rgb;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.Rgb;

[TestFixture]
public class RgbMonitorTests
{
    private RgbMonitor _rgbMonitor;

    [SetUp]
    public void SetUp()
    {
        _rgbMonitor = new RgbMonitor();
    }

    [Test]
    public void black_screen()
    {
        var color = _rgbMonitor.Display();
        color.Should().Be(Color.Black);
    }

    [TestCase(Color.Red, Color.Red)]
    [TestCase(Color.Green, Color.Green)]
    [TestCase(Color.Blue, Color.Blue)]
    public void one_light(Color light, Color expected)
    {
        _rgbMonitor.TurnOnLight(light);
        var color = _rgbMonitor.Display();
        color.Should().Be(expected);
    }

    [TestCase(new[] {Color.Red, Color.Green}, Color.Yellow)]
    [TestCase(new[] {Color.Red, Color.Blue}, Color.Violet)]
    [TestCase(new[] {Color.Green, Color.Blue}, Color.Cyan)]
    public void two_lights(Color[] lights, Color expected)
    {
        _rgbMonitor.TurnOnLight(lights[0]);
        _rgbMonitor.TurnOnLight(lights[1]);
        var color = _rgbMonitor.Display();
        color.Should().Be(expected);
    }

    [TestCase(new[] {Color.Red, Color.Green, Color.Blue}, Color.White)]
    public void three_lights(Color[] lights, Color expected)
    {
        _rgbMonitor.TurnOnLight(lights[0]);
        _rgbMonitor.TurnOnLight(lights[1]);
        _rgbMonitor.TurnOnLight(lights[2]);
        var color = _rgbMonitor.Display();
        color.Should().Be(expected);
    }

    [TestCase(new[] {Color.Red, Color.Green}, Color.Red, Color.Green)]
    [TestCase(new[] {Color.Red, Color.Blue}, Color.Blue, Color.Red)]
    [TestCase(new[] {Color.Red, Color.Green, Color.Blue}, Color.Green, Color.Violet)]
    public void remove_one_light(Color[] originalLights, Color lightToRemove, Color expected)
    {
        foreach (var light in originalLights)
        {
            _rgbMonitor.TurnOnLight(light);
        }

        _rgbMonitor.TurnOffLight(lightToRemove);
        var color = _rgbMonitor.Display();
        color.Should().Be(expected);
    }
}