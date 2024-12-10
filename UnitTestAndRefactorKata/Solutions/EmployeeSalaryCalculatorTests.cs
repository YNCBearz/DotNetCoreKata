using NUnit.Framework;

namespace UnitTestAndRefactorKata.Solutions;

[TestFixture]
public class EmployeeSalaryCalculatorTests
{
    private EmployeeSalaryCalculator _calculator;

    [SetUp]
    public void SetUp()
    {
        _calculator = new EmployeeSalaryCalculator();
    }

    [Test]
    public void full_time_no_over_time()
    {
        var netSalary = _calculator.GetNetSalary("Full-time", 0.1m, 1.5m, 100, 0);

        Assert.That(netSalary, Is.EqualTo(2700m));
    }

    [Test]
    public void part_time_no_over_time()
    {
        var netSalary = _calculator.GetNetSalary("Part-time", 0.1m, 1.5m, 100, 0);

        Assert.That(netSalary, Is.EqualTo(1800m));
    }

    [Test]
    public void intern_no_over_time()
    {
        var netSalary = _calculator.GetNetSalary("Intern", 0.1m, 1.5m, 100, 0);

        Assert.That(netSalary, Is.EqualTo(1350m));
    }

    [Test]
    public void contractor_no_over_time()
    {
        var netSalary = _calculator.GetNetSalary("Contractor", 0.1m, 1.5m, 100, 0);

        Assert.That(netSalary, Is.EqualTo(4500m));
    }

    [Test]
    public void unknown_type_throw_exception()
    {
        Assert.Throws<NotSupportedException>(() =>
        {
            _calculator.GetNetSalary("Unknown", 0.1m, 1.5m, 100, 0);
        });
    }
}