using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        public static void NoEmployee()
        {
            Console.WriteLine($"Employee First Name: -\nEmployee Last Name: -\nEmployee Middle Name: -\nEmployee Date of Birth: -\nAge: -");
        }
        public static  void printEmployeeDetails(Employee emp)
        {
            if (emp == null)
            {
                return;
            }
            string m = emp.MiddleName;
            string l = emp.LastName;
            if (string.IsNullOrEmpty(m))
            {
                m = "-";
            }
            if (string.IsNullOrEmpty(l))
            {
                l = "-";
            }
            if (emp.DateOfBirth == null)
            {
                Console.WriteLine($"Employee First Name: {emp.FirstName}\nEmployee Last Name: {l}\nEmployee Middle Name: {m}\nEmployee Date of Birth: -\nAge: -");
            }
            else
            {
                int age = (int)((DateTime.Now - emp.DateOfBirth.GetValueOrDefault()).TotalDays / 365.242199);
                Console.WriteLine($"Employee First Name: {emp.FirstName}\nEmployee Last Name: {l}\nEmployee Middle Name: {m}\nEmployee Date of Birth: {emp.DateOfBirth.GetValueOrDefault().ToString("MM/dd/yyyy")}\nAge: {age}");
            }

        }
        public static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee("Rohith","Bodagala",null,new DateTime(2000,4,19)));
            list.Add(new Employee("Spoorthi", "Umesh", null, new DateTime(2000, 3, 21)));
            list.Add(new Employee("Rahul", "Sharma", null, new DateTime(1999, 8, 10)));
            list.Add(new Employee("Pasala", "Vamshi", null, new DateTime(1999, 10, 15)));
            list.Add(new Employee("Santhosh", "Manjunatha", null, new DateTime(1998, 2, 22)));
            Console.WriteLine("Enter the First name to search:");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter the Last name to search:");
            string LastName = Console.ReadLine();
            foreach(Employee emp in list)
            {
                if(FirstName.Equals(emp.FirstName,StringComparison.OrdinalIgnoreCase) && LastName.Equals(emp.LastName, StringComparison.OrdinalIgnoreCase))
                {
                    printEmployeeDetails(emp);
                    return;
                }
            }
            NoEmployee();

        }
    }
}
