using DotNetCoreKata.Models;
using DotNetCoreKata.Services.Interview;
using FluentAssertions;
using NUnit.Framework;

namespace DotNetCoreKata.Tests.UnitTests.Services.Interview;

public class QuestionTests
{
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

    [TestCase(new[] {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}, nameof(AddAndSubtractTenIfMoreThanTen))]
    [TestCase(new[] {0}, nameof(Add))]
    public void is_closure(int[] setArray, string operationName)
    {
        var set = new HashSet<int>(setArray);

        Func<int, int, int> operation = operationName switch
        {
            nameof(Add) => Add,
            nameof(AddAndSubtractTenIfMoreThanTen) => AddAndSubtractTenIfMoreThanTen,
            _ => throw new ArgumentException("Invalid operation name", nameof(operationName))
        };

        var result = Question.IsClosure(set, operation);

        result.Should().BeTrue();
    }

    [Test]
    public void is_not_closure()
    {
        var set = new HashSet<int> {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};

        var result = Question.IsClosure(set, AddAndSubtractTen);
        result.Should().BeFalse();
    }

    [Test]
    public void buy_100_chicken_with_budget_100()
    {
        var expectedResults = new List<BuyChickenAnswer>
        {
            new BuyChickenAnswer(0, 25, 75),
            new BuyChickenAnswer(4, 18, 78),
            new BuyChickenAnswer(8, 11, 81),
            new BuyChickenAnswer(12, 4, 84)
        };

        var result = new Question().BuyChicken();
        result.Should().BeEquivalentTo(expectedResults);
    }

    private static int Add(int a, int b)
    {
        return a + b;
    }

    private static int AddAndSubtractTenIfMoreThanTen(int a, int b)
    {
        var result = Add(a, b);

        if (result >= 10)
        {
            return result - 10;
        }

        return result;
    }

    private static int AddAndSubtractTen(int a, int b) => Add(a, b) - 10;
}