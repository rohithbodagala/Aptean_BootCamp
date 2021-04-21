using System;

namespace Employee
{
    class Program
    {
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
            string FirstName, LastName, MiddleName;
            int date, month, year;
            bool isdate, ismonth, isyear;
            DateTime? dob;
            Console.WriteLine("Enter First Name");
            FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            LastName= Console.ReadLine();
            Console.WriteLine("Enter Middle Name");
            MiddleName= Console.ReadLine();
            Console.WriteLine("Enter Date of birth");
            isdate=int.TryParse(Console.ReadLine(),out date);
            Console.WriteLine("Enter Month of birth");
            ismonth= int.TryParse(Console.ReadLine(),out month);
            Console.WriteLine("Enter Year of birth");
            isyear= int.TryParse(Console.ReadLine(),out year);
            if (string.IsNullOrEmpty(MiddleName))
            {
                MiddleName = null;
            }
            if (string.IsNullOrEmpty(LastName))
            {
                LastName = null;
            }
            if(!isyear || !ismonth || !isdate)
            {
                dob = null;
            }
            else
            {
                dob = new DateTime(year, month, date);
            }
            
            Employee emp = new Employee(FirstName, LastName, MiddleName,dob);
            printEmployeeDetails(emp);
            Employee emp1 = null;
            printEmployeeDetails(emp1);

        }
    }
}
