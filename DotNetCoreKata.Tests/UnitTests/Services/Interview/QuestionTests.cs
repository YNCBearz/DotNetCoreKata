using DotNetCoreKata.Services.Interview;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.Interview;

public class QuestionTests
{
    private Question _sut = null!;

    [SetUp]
    public void SetUp()
    {
        _sut = new Question();
    }

    [TestCase(1)]
    [TestCase(2)]
    [TestCase(4)]
    [TestCase(8)]
    public void power_of_two(int input)
    {
        var result = _sut.IsPowerOfTwo(input);
        result.Should().BeTrue();
    }

    [TestCase(0)]
    [TestCase(3)]
    [TestCase(5)]
    public void not_power_of_two(int input)
    {
        var result = _sut.IsPowerOfTwo(input);
        result.Should().BeFalse();
    }
}