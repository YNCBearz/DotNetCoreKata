using DotNetCoreKata.Services.Overcooked.MysteriousName;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.Overcooked.MysteriousName;

[TestFixture]
public class BeverageStoreTests
{
    [Test]
    public void bumble_tea()
    {
        // Arrange
        var beverageStore = new BeverageStore();
        
        // Act
        var drink = beverageStore.Order("qqneineidrinkabletomeiputea", "half sugar", "less ice");
        
        // Assert
        drink.GetDescription().Should().Be("BubbleTea: half sugar, less ice");
    }
    
    [Test]
    public void default_coke()
    {
        // Arrange
        var beverageStore = new BeverageStore();
        
        // Act
        var drink = beverageStore.Order("unknown", "no sugar", "less ice");
        
        // Assert
        drink.GetDescription().Should().Be("Coke: no sugar, less ice");
    }

}