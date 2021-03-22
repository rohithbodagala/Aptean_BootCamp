using System;
using System.Reflection;

namespace People
{
    public class Citizen : IPerson,IIdentifiable,IBirthable
    {
        public string name { get; set; }
        public int age { get; set; }
        public string id { get; set; }
        public string birthdate { get; set; }

        public Citizen(string name, int age,string id,string birthdate)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            this.birthdate = birthdate;
        }

        static void Main(string[] args)
        {
            //Console.Write("Enter the name of the person: ");
            var name = Console.ReadLine();
            //Console.Write("Enter the age of the person: ");
            var age = int.Parse(Console.ReadLine());
            //Console.Write("Enter the id of the person: ");
            var id = Console.ReadLine();
            //Console.Write("Enter the birthdate of the person: ");
            var birthdate = Console.ReadLine();
            Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            PropertyInfo[] properties = identifiableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            properties = birthableInterface.GetProperties();
            Console.WriteLine(properties.Length);
            Console.WriteLine(properties[0].PropertyType.Name);
            
            IIdentifiable identifiable = new Citizen(name, age,id,birthdate);
            IIdentifiable birthable = new Citizen(name, age, id, birthdate);



        }
    }
}
