namespace UnitTestAndRefactorKata.Solutions;

// DuplicateCode
// MagicNumber
// FeatureEnvy
// LongParameters
// PrimitiveObsession
// SwitchCase

public class EmployeeRepo
{
    public int GetHoursWorked(string employeeId, int month, int year)
    {
        // 模擬從資料庫獲取數據
        Console.WriteLine($"Fetching work hours for EmployeeId: {employeeId}, Month: {month}, Year: {year}");
        return (int) (DateTime.Now - new DateTime(year, month, 1)).TotalHours;
    }

    public decimal GetEmployeeBonus(string employeeType)
    {
        // 模擬計算獎金的邏輯
        if (employeeType == "Full-time")
        {
            return 500; // 魔法數字：固定獎金
        }
        else if (employeeType == "Part-time")
        {
            return 100; // 魔法數字：固定獎金
        }

        return 0;
    }
}

public class Rate
{
    public Rate(decimal taxRate, decimal overtimeRate)
    {
        TaxRate = taxRate;
        OvertimeRate = overtimeRate;
    }

    public decimal TaxRate { get; private set; }
    public decimal OvertimeRate { get; private set; }
}

public class EmployeeSalaryCalculator
{
    private readonly EmployeeRepo _employeeRepo = new EmployeeRepo();

    public decimal CalculateSalary(
        string employeeType,
        string employeeId,
        int month,
        int year,
        decimal taxRate = 0.1m,
        decimal overtimeRate = 1.5m
    )
    {
        // this is our dependency
        
        var employee = new Employee()
        {
            Id = employeeId,
            Type = employeeType,
            WorkingHours = _employeeRepo.GetHoursWorked(employeeId, month, year),
            Bonus = _employeeRepo.GetEmployeeBonus(employeeType),
        };

        // this is the logic we want to test

        return GetNetSalary(new Rate(taxRate, overtimeRate), employee);
    }

    private decimal GetNetSalary(Rate rate, Employee employee)
    {
        decimal baseSalary;

        switch (employee.Type)
        {
            case "Full-time":
                baseSalary = 3000;
                break;
            case "Part-time":
                baseSalary = employee.WorkingHours * 20;
                break;
            case "Intern":
                baseSalary = employee.WorkingHours * 15;
                break;
            case "Contractor":
                baseSalary = employee.WorkingHours * 50;
                break;
            default:
                throw new NotSupportedException("Unknown employee type");
        }

        // 加班薪資
        decimal overtimeSalary = 0;

        overtimeSalary = OvertimeSalary(rate, employee, overtimeSalary, baseSalary);

        // 總薪資
        var grossSalary = baseSalary + employee.Bonus + overtimeSalary;
        // 稅金
        var tax = grossSalary * rate.TaxRate;
        // 淨薪資
        var netSalary = grossSalary - tax;

        return netSalary;
    }

    private static decimal OvertimeSalary(Rate rate, Employee employee, decimal overtimeSalary, decimal baseSalary)
    {
        if (employee.WorkingHours > 160)
        {
            var overtimeHours = employee.WorkingHours - 160;
            overtimeSalary = overtimeHours * (baseSalary / 160) * rate.OvertimeRate;
        }

        return overtimeSalary;
    }

    public decimal GetNetSalary(string employeeType, decimal taxRate, decimal overtimeRate, int hoursWorked, decimal bonus)
    {
        var employee = new Employee()
        {
            Type = employeeType,
            WorkingHours = hoursWorked,
            Bonus = bonus
        };

        return GetNetSalary(new Rate(taxRate, overtimeRate), employee);
    }
}

public class Employee
{
    public string Id { get; set; }
    public string Type { get; set; }
    public int WorkingHours { get; set; }
    public decimal Bonus { get; set; }
}