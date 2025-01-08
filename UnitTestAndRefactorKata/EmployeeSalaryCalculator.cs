namespace UnitTestAndRefactorKata;

// DuplicateCode
// MagicNumber
// FeatureEnvy
// LongParameters
// PrimitiveObsession
// SwitchCase

public class EmployeeSalaryCalculator
{
    private readonly IEmployeeRepo _employeeRepo;

    public EmployeeSalaryCalculator(IEmployeeRepo employeeRepo)
    {
        _employeeRepo = employeeRepo;
    }

    public decimal CalculateSalary(
        string employeeType,
        string employeeId,
        int month,
        int year,
        decimal taxRate = 0.1m,
        decimal overtimeRate = 1.5m
    )
    {
        var bonus = _employeeRepo.GetEmployeeBonus(employeeId, employeeType); // Feature Envy：調用外部類別
        decimal baseSalary = 0;
        // this is our dependency
        var hoursWorked = _employeeRepo.GetHoursWorked(employeeId, month, year);

        // this is the logic we want to test
        baseSalary = GetBaseSalary(employeeType, hoursWorked);

        decimal overtimeSalary = 0;

        if (hoursWorked > 160)
        {
            var overtimeHours = hoursWorked - 160;
            overtimeSalary = overtimeHours * (baseSalary / 160) * overtimeRate;
        }

        var grossSalary = baseSalary + bonus + overtimeSalary;
        var tax = grossSalary * taxRate;
        var netSalary = grossSalary - tax;

        return netSalary;
    }

    private static decimal GetBaseSalary(string employeeType, int hoursWorked)
    {
        var dictionary = new Dictionary<string, Func<int>>()
        {
            {"Full-time", () => 3200},
            {"Part-time", () => hoursWorked * 20},
            {"Intern", () => hoursWorked * 15},
            {"Contractor", () => hoursWorked * 50},
        };

        if (!dictionary.ContainsKey(employeeType))
        {
            throw new NotSupportedException("Unknown employee type");
        }

        return dictionary[employeeType]();
    }
}