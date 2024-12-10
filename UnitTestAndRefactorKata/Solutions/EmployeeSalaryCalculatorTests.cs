using NUnit.Framework;

namespace UnitTestAndRefactorKata.Solutions;

[TestFixture]
public class EmployeeSalaryCalculatorTests
{
    [Test]
    public void full_time_no_over_time()
    {
        var calculator = new EmployeeSalaryCalculator();
        var netSalary = calculator.GetNetSalary("Full-time",0.1m,1.5m, 100, 0);
        
        Assert.AreEqual(2700m, netSalary);
    }
}