namespace UnitTestAndRefactorKata;

public interface IEmployeeRepo
{
    int GetHoursWorked(string employeeId, int month, int year);
    decimal GetEmployeeBonus(string employeeId, string employeeType);
}