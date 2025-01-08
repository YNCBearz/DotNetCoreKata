namespace UnitTestAndRefactorKata;

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