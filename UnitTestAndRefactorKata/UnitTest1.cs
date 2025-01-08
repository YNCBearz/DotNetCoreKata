using NSubstitute;
using NUnit.Framework;

namespace UnitTestAndRefactorKata;

public class Tests
{
    [SetUp]
    public void Setup()
    { }

    [Test]
    public void full_time_salary()
    {
        var employeeRepo = NSubstitute.Substitute.For<IEmployeeRepo>();

        var employeeSalaryCalculator = new EmployeeSalaryCalculator(employeeRepo);
        employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
        employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);

        var calculateSalary = employeeSalaryCalculator.CalculateSalary("Full-time", "1", 1, 2022, 0.2m, 2m);

        Assert.AreEqual(5440, calculateSalary);
    }

    [Test]
    public void Intern_salary()
    {
        var employeeRepo = NSubstitute.Substitute.For<IEmployeeRepo>();

        var employeeSalaryCalculator = new EmployeeSalaryCalculator(employeeRepo);
        employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
        employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);

        var calculateSalary = employeeSalaryCalculator.CalculateSalary("Intern", "1", 1, 2022, 0.2m, 2m);

        Assert.AreEqual(5200, calculateSalary);
    }

    [Test]
    public void Part_time_salary()
    {
        var employeeRepo = NSubstitute.Substitute.For<IEmployeeRepo>();

        var employeeSalaryCalculator = new EmployeeSalaryCalculator(employeeRepo);
        employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
        employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);

        var calculateSalary = employeeSalaryCalculator.CalculateSalary("Part-time", "1", 1, 2022, 0.2m, 2m);

        Assert.AreEqual(6400, calculateSalary);
    }

    [Test]
    public void Contractor_salary()
    {
        var employeeRepo = NSubstitute.Substitute.For<IEmployeeRepo>();

        var employeeSalaryCalculator = new EmployeeSalaryCalculator(employeeRepo);
        employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
        employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);

        var calculateSalary = employeeSalaryCalculator.CalculateSalary("Contractor", "1", 1, 2022, 0.2m, 2m);

        Assert.AreEqual(13600, calculateSalary);
    }

    [Test]
    public void unknown_employee_salary()
    {
        var employeeRepo = NSubstitute.Substitute.For<IEmployeeRepo>();

        var employeeSalaryCalculator = new EmployeeSalaryCalculator(employeeRepo);
        employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
        employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);

        Assert.Throws<NotSupportedException>(() => employeeSalaryCalculator.CalculateSalary("Bear", "1", 1, 2022, 0.2m, 2m));
    }
}