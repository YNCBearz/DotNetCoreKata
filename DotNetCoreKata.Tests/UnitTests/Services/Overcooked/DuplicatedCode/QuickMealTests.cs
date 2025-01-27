using DotNetCoreKata.DomainModels.Overcooked.DuplicatedCode;
using DotNetCoreKata.Services.Overcooked.DuplicatedCode;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.Overcooked.DuplicatedCode;

[TestFixture]
public class QuickMealTests
{
	private QuickMeal _quickMeal;

	[SetUp]
	public void SetUp()
	{
		_quickMeal = new QuickMeal();
	}

	[Test]
	public void egg_fried_rice()
	{
		// Arrange

		// Act
		var meal = _quickMeal.PrepareForEggFriedRice();

		// Assert
		meal.Should().BeOfType<EggFriedRice>();
	}

	[Test]
	public void pork_cutlet_rice()
	{
		// Arrange

		// Act
		var meal = _quickMeal.PrepareForPorkCutletRice();

		// Assert
		meal.Should().BeOfType<PorkCutletRice>();
	}
}