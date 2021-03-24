using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace GroupEmployees
{
    class Program
    {
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
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
            var vowels = new char[]{ 'a', 'e', 'i', 'o', 'u' };

            var Query = from employee in Employees
                        where vowels.Contains(employee.SurName[1])
                        select employee;
            Console.WriteLine($"Reverse names of Employee First Names whose second letter of SurName is a vowel:\n");
            foreach (var employee in Query)
            {
                Console.WriteLine($"FirstName: {Reverse(employee.FirstName)}\t Surname:{employee.SurName}");
            }
        }
    }
}
