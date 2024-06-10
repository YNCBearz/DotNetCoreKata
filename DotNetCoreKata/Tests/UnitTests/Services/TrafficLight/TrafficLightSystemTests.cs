using DotNetCoreKata.DomainModels.TrafficLight;
using DotNetCoreKata.Services.TrafficLight;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.TrafficLight;

[TestFixture]
public class TrafficLightSystemTests
{
    private StringWriter? _consoleOutput;

    [SetUp]
    public void SetUp()
    {
        _consoleOutput = new StringWriter();
        Console.SetOut(_consoleOutput);
    }

    [Test]
    public void Green()
    {
        var nextTrafficLight = TrafficLightSystem.NextColor(new DomainModels.TrafficLight.TrafficLight("Red"));
        CarShould(nextTrafficLight, "Drive");
    }

    private void CarShould(ITrafficLight nextTrafficLight, string expected)
    {
        nextTrafficLight.Check(new Car());
        _consoleOutput?.ToString().Should().Be(expected);
    }

    [Test]
    public void Yellow()
    {
        var nextTrafficLight = TrafficLightSystem.NextColor(new DomainModels.TrafficLight.TrafficLight("Green"));
        CarShould(nextTrafficLight, "Stop");
    }

    [Test]
    public void Red()
    {
        var nextTrafficLight = TrafficLightSystem.NextColor(new DomainModels.TrafficLight.TrafficLight("Yellow"));
        CarShould(nextTrafficLight, "Stop");
    }

}