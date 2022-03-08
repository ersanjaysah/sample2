using System;

namespace EmpWages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Attendance();

            employee.DailyWage();
           
        }
    }
}
