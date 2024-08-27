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
        var drink = beverageStore.Get("qqneineidrinkabletomeiputea", "half sugar", "less ice");
        
        // Assert
        drink.GetContent().Should().Be("BubbleTea: half sugar, less ice");
    }
    
    [Test]
    public void default_coke()
    {
        // Arrange
        var beverageStore = new BeverageStore();
        
        // Act
        var drink = beverageStore.Get("unknown", "no sugar", "less ice");
        
        // Assert
        drink.GetContent().Should().Be("Coke: no sugar, less ice");
    }

}