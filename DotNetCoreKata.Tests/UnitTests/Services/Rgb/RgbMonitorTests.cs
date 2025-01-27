using DotNetCoreKata.Enums;
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

	[TestCase(RgbColor.Red, Color.Red)]
	[TestCase(RgbColor.Green, Color.Green)]
	[TestCase(RgbColor.Blue, Color.Blue)]
	public void one_light(RgbColor light, Color expected)
	{
		_rgbMonitor.TurnOnLight(light);
		var color = _rgbMonitor.Display();
		color.Should().Be(expected);
	}

	[TestCase(new[] { RgbColor.Red, RgbColor.Green }, Color.Yellow)]
	[TestCase(new[] { RgbColor.Red, RgbColor.Blue }, Color.Magenta)]
	[TestCase(new[] { RgbColor.Green, RgbColor.Blue }, Color.Cyan)]
	public void two_lights(RgbColor[] lights, Color expected)
	{
		_rgbMonitor.TurnOnLight(lights[0]);
		_rgbMonitor.TurnOnLight(lights[1]);
		var color = _rgbMonitor.Display();
		color.Should().Be(expected);
	}

	[TestCase(new[] { RgbColor.Red, RgbColor.Green, RgbColor.Blue }, Color.White)]
	public void three_lights(RgbColor[] lights, Color expected)
	{
		_rgbMonitor.TurnOnLight(lights[0]);
		_rgbMonitor.TurnOnLight(lights[1]);
		_rgbMonitor.TurnOnLight(lights[2]);
		var color = _rgbMonitor.Display();
		color.Should().Be(expected);
	}

	[TestCase(new[] { RgbColor.Red, RgbColor.Green }, RgbColor.Red, Color.Green)]
	[TestCase(new[] { RgbColor.Red, RgbColor.Blue }, RgbColor.Blue, Color.Red)]
	[TestCase(new[] { RgbColor.Red, RgbColor.Green, RgbColor.Blue }, RgbColor.Green, Color.Magenta)]
	public void remove_one_light(RgbColor[] originalLights, RgbColor lightToRemove, Color expected)
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