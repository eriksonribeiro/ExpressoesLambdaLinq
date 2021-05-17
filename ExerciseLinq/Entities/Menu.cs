using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseLinq.Entities
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            List<Employee> employeesList = EmployeeOperation.ImportEmployee();

            foreach (var employee in employeesList)
                Console.WriteLine(employee);
            Console.WriteLine();

            Console.Write("Fill the Salary Value to search the employee is more than: ");
            double salary = Double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine();
            IEnumerable<string> emailSalaries = EmployeeOperation.ShowEmailEmployee(employeesList, salary);
            foreach (var email in emailSalaries)
                Console.WriteLine(email);

            Console.WriteLine();
            char letter = 'M';
            double sumSalary = EmployeeOperation.SumSalaryWithLetter(employeesList, letter);
            Console.WriteLine($"Sum of salary of people whose name starts with '{letter}': {sumSalary.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}
