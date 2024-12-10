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
        var bonus = _employeeRepo.GetEmployeeBonus(employeeId, employeeType);   // Feature Envy：調用外部類別
        decimal baseSalary = 0;
        // this is our dependency
        var hoursWorked = _employeeRepo.GetHoursWorked(employeeId, month, year);

        // this is the logic we want to test
        switch (employeeType)
        {
            case "Full-time":
                baseSalary = 3000; 
                break;
            case "Part-time":
                baseSalary = hoursWorked * 20; 
                break;
            case "Intern":
                baseSalary = hoursWorked * 15; 
                break;
            case "Contractor":
                baseSalary = hoursWorked * 50; 
                break;
            default:
                throw new NotSupportedException("Unknown employee type");
        }

        
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
}