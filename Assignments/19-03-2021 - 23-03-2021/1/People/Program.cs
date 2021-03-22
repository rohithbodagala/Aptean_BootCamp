using System;
using System.Reflection;

namespace People
{
    public class Citizen : IPerson
    {
        public string name { get; set; }
        public int age { get; set; }

        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        static void Main(string[] args)
        {
            Type IPerson = typeof(Citizen).GetInterface("IPerson");
            PropertyInfo[] properties = IPerson.GetProperties();
            Console.Write("Enter the name of the person: ");
            var name = Console.ReadLine();
            Console.Write("Enter the age of the person: ");
            var age = int.Parse(Console.ReadLine());
            IPerson person = new Citizen(name, age);
            Console.WriteLine(properties.Length);
            Console.WriteLine(person.name);
            Console.WriteLine(person.age);


        }
    }
}
