using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace ExerciseLinq.Entities
{
    public static class EmployeeOperation
    {
        public static List<Employee> ImportEmployee()
        {
            List<Employee> employeeList = new List<Employee>();
            try
            {
                Console.Write("Put the directory path of employees files:");
                string path = Console.ReadLine();
                Console.WriteLine();
                DirectoryInfo directory = new DirectoryInfo(path);

                if (!directory.Exists)
                {
                    Console.WriteLine("Diretory filled does not exist!");
                    return employeeList;
                }
                else
                {
                    foreach (var file in directory.GetFiles("*.csv"))
                    {
                        Console.WriteLine($"Importing File: {file.Name}");
                        using (StreamReader reader = new StreamReader(path + file.Name))
                        {
                            while (!reader.EndOfStream)
                            {
                                string[] data = reader.ReadLine().Split(';');
                                string name = data[0];
                                string email = data[1];
                                double salary = Double.Parse(data[2], CultureInfo.InvariantCulture);
                                employeeList.Add(new Employee(name, email, salary));
                            }
                            Console.WriteLine($"File: {file.Name} imported with success!");
                            Console.WriteLine();
                        }
                    }

                    return employeeList;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return employeeList;
            }
        
        }

        public static IEnumerable<string> ShowEmailEmployee(List<Employee> employeeList, double salary)
        {
            IEnumerable<string> emails = employeeList.Where(e => e.Salary > salary).OrderBy(e => e.Email).Select(e => e.Email);
          return emails;
        }

        public static double SumSalaryWithLetter(List<Employee> employeeList, char letter)
        {
            double sumSalary = employeeList.Where(e => e.Name[0] == letter).Select(e => e.Salary).Aggregate(0.0,(x,y)=>(x+y));
            return sumSalary;
        }
    }
}
