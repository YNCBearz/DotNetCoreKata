using DotNetCoreKata.DomainModels.AgeOfEmpires;
using DotNetCoreKata.Enums;
using DotNetCoreKata.Services.AgeOfEmpires;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.AgeOfEmpires;

[TestFixture]
public class ProgramTests
{
    private DotNetCoreKata.Services.AgeOfEmpires.Program _program;

    [SetUp]
    public void SetUp()
    {
        GivenProgram();
    }

    [Test]
    public void Militia()
    {
        var unit = _program.Train(UnitCategory.Military);

        unit.Should().BeOfType<Unit>();
        unit.Attack().Should().Be("attacks with stick");
        unit.Move().Should().Be("moves using legs");
    }

    [Test]
    public void Archer()
    {
        var unit = _program.Train(UnitCategory.Archer);

        unit.Should().BeOfType<Unit>();
        unit.Attack().Should().Be("attacks with bow");
        unit.Move().Should().Be("moves using legs");
    }

    private void GivenProgram()
    {
        var trainingCenter = new DotNetCoreKata.Services.AgeOfEmpires.Program();
        _program = trainingCenter;
    }
}