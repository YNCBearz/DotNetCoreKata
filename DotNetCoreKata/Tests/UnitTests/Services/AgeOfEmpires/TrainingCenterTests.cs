using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.AgeOfEmpires;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.AgeOfEmpires;

[TestFixture]
public class TrainingCenterTests
{
    private TrainingCenter _trainingCenter;

    [SetUp]
    public void SetUp()
    {
        GivenTrainingCenter();
    }

    [Test]
    public void Militia()
    {
        GivenTrainingCenter();

        var unit = _trainingCenter.Train(UnitCategory.Military);

        unit.Should().BeOfType<Unit>();
        unit.Attack().Should().Be("attacks with stick");
        unit.Move().Should().Be("moves using legs");
    }

    [Test]
    public void Archer()
    {
        var unit = _trainingCenter.Train(UnitCategory.Archer);

        unit.Should().BeOfType<Unit>();
        unit.Attack().Should().Be("attacks with bow");
        unit.Move().Should().Be("moves using legs");
    }

    private void GivenTrainingCenter()
    {
        var trainingCenter = new TrainingCenter();
        _trainingCenter = trainingCenter;
    }
}