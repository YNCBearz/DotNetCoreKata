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
        var result = Question.IsPowerOfTwo(input);
        result.Should().BeTrue();
    }

    [TestCase(0)]
    [TestCase(3)]
    [TestCase(5)]
    public void not_power_of_two(int input)
    {
        var result = Question.IsPowerOfTwo(input);
        result.Should().BeFalse();
    }

    [TestCase(1, 1)]
    [TestCase(12, 3)]
    [TestCase(56, 2)]
    public void single_digit(int input, int expected)
    {
        var result = Question.SingleDigit(input);
        result.Should().Be(expected);
    }
    
    [Test]
    public void is_closure()
    {
        var set = new HashSet<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        var result = Question.IsClosure(set, AddAndSubtractTenIfMoreThanTen);
        result.Should().BeTrue();
    }

    private static int AddAndSubtractTenIfMoreThanTen(int a, int b)
    {
        var result = a + b;

        if (result >= 10)
        {
            return result - 10;
        }

        return result;
    }


    [Test]
    public void is_not_closure()
    {
        var set = new HashSet<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        var result = Question.IsClosure(set, AddAndSubtractTen);
        result.Should().BeFalse();
    }
    private static int AddAndSubtractTen(int a, int b) => (a + b) - 10;

}
