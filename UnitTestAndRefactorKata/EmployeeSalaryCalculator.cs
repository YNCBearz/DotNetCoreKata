namespace UnitTestAndRefactorKata;

// DuplicateCode
// MagicNumber
// FeatureEnvy
// LongParameters
// PrimitiveObsession
// SwitchCase

public interface IEmployeeRepo
{
    int GetHoursWorked(string employeeId, int month, int year);
    decimal GetEmployeeBonus(string employeeId, string employeeType);
}

public class EmployeeRepo : IEmployeeRepo
{
    public int GetHoursWorked(string employeeId, int month, int year)
    {
        // 模擬從資料庫獲取數據
        Console.WriteLine($"Fetching work hours for EmployeeId: {employeeId}, Month: {month}, Year: {year}");
        return (int)(DateTime.Now - new DateTime(year, month, 1)).TotalHours;
    }

    public decimal GetEmployeeBonus(string employeeId, string employeeType)
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

public class Employee
{
    public Employee(string employeeType, int hoursWorked, decimal bonus)
    {
        EmployeeType = employeeType;
        HoursWorked = hoursWorked;
        Bonus = bonus;
    }

    public string EmployeeType { get; private set; }
    public int HoursWorked { get; private set; }
    public decimal Bonus { get; private set; }

    public decimal GetBaseSalary()
    {
        decimal baseSalary;

        switch (EmployeeType)
        {
            case "Full-time":
                baseSalary = 3200;
                break;
            case "Part-time":
                baseSalary = HoursWorked * 20;
                break;
            case "Intern":
                baseSalary = HoursWorked * 15;
                break;
            case "Contractor":
                baseSalary = HoursWorked * 50;
                break;
            default:
                throw new NotSupportedException("Unknown employee type");
        }

        return baseSalary;
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

    public decimal GetOvertimeSalary(Employee employee)
    {
        if (employee.HoursWorked > 160)
        {
            var overtimeHours = employee.HoursWorked - 160;
            var overtimeSalary = overtimeHours * (employee.GetBaseSalary() / 160) * OvertimeRate;
            return overtimeSalary;
        }

        return 0;
    }
}

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
        return GetNetSalary(new Employee(employeeType, hoursWorked, bonus), new Rate(taxRate, overtimeRate));
    }

    private static decimal GetNetSalary(Employee employee, Rate rate)
    {
        var baseSalary = employee.GetBaseSalary();
        var overtimeSalary = rate.GetOvertimeSalary(employee);

        var grossSalary = baseSalary + employee.Bonus + overtimeSalary;
        var tax = grossSalary * rate.TaxRate;
        var netSalary = grossSalary - tax;

        return netSalary;
    }
}