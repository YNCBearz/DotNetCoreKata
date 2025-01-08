using NSubstitute;
using NUnit.Framework;

namespace UnitTestAndRefactorKata
{
    public class Tests
    {
        private IEmployeeRepo _employeeRepo;
        private EmployeeSalaryCalculator _employeeSalaryCalculator;

        [SetUp]
        public void Setup()
        {
            _employeeRepo = Substitute.For<IEmployeeRepo>();
            _employeeSalaryCalculator = new EmployeeSalaryCalculator(_employeeRepo);
            _employeeRepo.GetEmployeeBonus(Arg.Any<string>(), Arg.Any<string>()).Returns(2000m);
            _employeeRepo.GetHoursWorked(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<int>()).Returns(200);
        }

        [TestCase("Full-time", 5440)]
        [TestCase("Intern", 5200)]
        [TestCase("Part-time", 6400)]
        [TestCase("Contractor", 13600)]
        public void CalculateSalary_ShouldReturnCorrectSalary_ForDifferentEmployeeTypes(string employeeType, decimal expectedSalary)
        {
            var calculateSalary = _employeeSalaryCalculator.CalculateSalary(employeeType, "1", 1, 2022, 0.2m, 2m);
            Assert.AreEqual(expectedSalary, calculateSalary);
        }

        [Test]
        public void CalculateSalary_ShouldThrowNotSupportedException_ForUnknownEmployeeType()
        {
            Assert.Throws<NotSupportedException>(() => _employeeSalaryCalculator.CalculateSalary("Bear", "1", 1, 2022, 0.2m, 2m));
        }
    }
}
