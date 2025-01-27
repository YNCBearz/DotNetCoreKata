using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.AgeOfEmpires;

[TestFixture]
public class ClientTests
{
	private DotNetCoreKata.Services.AgeOfEmpires.Client _client;

	[SetUp]
	public void SetUp()
	{
		GivenClient();
	}

	[Test]
	public void Militia()
	{
		// Arrange
		const UnitCategory unitCategory = UnitCategory.Military;

		// Act
		var unit = _client.Train(unitCategory);

		// Assert
		unit.Should().BeOfType<Unit>();
		unit.Attack().Should().Be("attacks with stick");
		unit.Move().Should().Be("moves using legs");
	}

	[Test]
	public void Archer()
	{
		// Arrange
		const UnitCategory unitCategory = UnitCategory.Archer;

		// Act
		var unit = _client.Train(unitCategory);

		// Assert
		unit.Should().BeOfType<Unit>();
		unit.Attack().Should().Be("attacks with bow");
		unit.Move().Should().Be("moves using legs");
	}

	[Test]
	public void Knight()
	{
		// Arrange
		const UnitCategory unitCategory = UnitCategory.Knight;

		// Act
		var unit = _client.Train(unitCategory);

		// Assert
		unit.Should().BeOfType<Unit>();
		unit.Attack().Should().Be("attacks with sword");
		unit.Move().Should().Be("moves using horse");
	}

	private void GivenClient()
	{
		_client = new DotNetCoreKata.Services.AgeOfEmpires.Client();
	}
}