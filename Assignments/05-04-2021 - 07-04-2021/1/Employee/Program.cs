using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            string FirstName, LastName, MiddleName;
            int date, month, year;
            Console.WriteLine("Enter First Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            LastName= Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            MiddleName= Console.ReadLine();
            Console.WriteLine("Enter Date of birth");
            date=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Month of birth");
            month= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Year of birth");
            year= int.Parse(Console.ReadLine());
            if (MiddleName == "")
            {
                MiddleName = null;
            }
            DateTime dob = new DateTime(year, month, date);
            Employee emp = new Employee(FirstName, LastName, MiddleName,dob);
            emp.printEmployeeDetails();

        }
    }
}
