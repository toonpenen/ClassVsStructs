using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassVsStructs
{
    public class Employee
    {
        public string Name;
        public double Salary;

        public double Update(Employee employee)
        {
            double newSalary = 3000.00;
            return employee.Salary = newSalary;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Salary = 2000.00;

            Console.WriteLine($"Salary before update {employee.Salary}");
            employee.Update(employee);
            Console.WriteLine($"Salary after update {employee.Salary}");

        }
    }
}
