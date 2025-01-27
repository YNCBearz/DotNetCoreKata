using DotNetCoreKata.Services.ZooKeeper;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.ZooKeeper;

[TestFixture]
public class ZooTests : IDisposable
{
	private StringWriter? _consoleOutput;

	[SetUp]
	public void SetUp()
	{
		_consoleOutput = new StringWriter();
		Console.SetOut(_consoleOutput);
	}

	[Test]
	public void monkey_eats_banana()
	{
		// Arrange
		var zoo = new Zoo();

		// Act
		zoo.FeedAnimals();

		// Assert
		OutputShouldContain("Monkey eats banana");
	}

	[Test]
	public void cow_eats_grass()
	{
		// Arrange
		var zoo = new Zoo();

		// Act
		zoo.FeedAnimals();

		// Assert
		OutputShouldContain("Cow eats grass");
	}

	[Test]
	public void lion_eats_meat()
	{
		// Arrange
		var zoo = new Zoo();

		// Act
		zoo.FeedAnimals();

		// Assert
		OutputShouldContain("Lion eats meat");
	}

	private void OutputShouldContain(string message)
	{
		_consoleOutput?.ToString().Should().Contain(message);
	}

	public void Dispose()
	{
		_consoleOutput?.Dispose();
	}
}