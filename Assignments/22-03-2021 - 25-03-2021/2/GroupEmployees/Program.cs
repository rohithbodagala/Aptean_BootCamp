using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroupEmployees
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"..\..\..\EmployeeList.txt";
            List<Employee> Employees = new List<Employee>();
            var lines = File.ReadAllLines(file);
            foreach (var line in lines)
            {
                var words = line.Split(',');
                Employees.Add(new Employee(int.Parse(words[0]), words[1], words[2]));

            }
            
            var Query = from employee in Employees
                        group employee by employee.FirstName[0];
            foreach (var group in Query)
            {
                Console.WriteLine($"Employees whose name starts with letter \"{group.Key}\":");
                foreach(var employee in group)
                {
                    Console.WriteLine(employee.ToString());
                }
                Console.WriteLine();
            }
        }
    }
}
