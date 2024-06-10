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

    [Ignore("")]
    [TestCase(123, 321)]
    [TestCase(120, 21)]
    public void reverse_number(int input, int expected)
    {
        ReverseNumberShouldBe(input, expected);
    }

    private void ReverseNumberShouldBe(int input, int expected)
    {
        var result = _sut.Reverse(input);
        result.Should().Be(expected);
    }
}

public class Question
{
    public int Reverse(int n)
    {
        var a = n.ToString();
        var reverseString = n.ToString().Reverse().ToList();
        return Convert.ToInt32(reverseString);
    }
}