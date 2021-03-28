using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonDNA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>(10);
            List<PersonEvolution> PersonEvolutionList = new List<PersonEvolution>();
            Console.WriteLine("Enter the number of people under test: ");
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter details of person {i} in the format - Name,Age,DNA string:");
                var input = Console.ReadLine().Split(',');
                try
                {
                    if (input[2].Length != 25 || !input[2].All(c => "ATGC".Contains(c)))
                        throw new Exception();
                    Person p = new Person(input[0], int.Parse(input[1]), input[2]);
                    PersonList.Add(p);
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid DNA String");
                }
                
            }
            while (true)
            {
                Console.WriteLine("Enter the below options:");
                Console.WriteLine("1. Perform Operation");
                Console.WriteLine("2. Display Information");
                Console.WriteLine("3. Quit");
                var ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        foreach(var p in PersonList)
                        {
                            Console.WriteLine(p.name);
                        }
                        Console.WriteLine("Enter the Person name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter the character to be replaced: ");
                        var from = char.Parse(Console.ReadLine());
                        Console.WriteLine($"Enter the character to replace {from} with: ");
                        var to = char.Parse(Console.ReadLine());
                        foreach(var p in PersonList)
                        {
                            if (p.name.Equals(name))
                            {
                                if (from.ToString().All(c => "ATGC".Contains(c)) && to.ToString().All(c => "ATGC".Contains(c)))
                                {
                                    Person np = new Person(p.name,p.age,p.DNA.Replace(from,to));
                                    PersonEvolutionList.Add(new PersonEvolution(np, from, to));
                                    Console.WriteLine("Operation Performed");
                                }
                                else
                                    Console.WriteLine("Invalid Operation!");
                                
                            }
                                
                        }
                       break;
                    case 2:
                        foreach (var p in PersonList)
                        {
                            Console.WriteLine(p.name);
                        }
                        Console.WriteLine(" Enter the name of Person whose details has to be displayed:");
                        name = Console.ReadLine();
                        Console.WriteLine($"The DNA evolution of {name} is as below,");
                        foreach(var p in PersonList) {
                            if (p.name.Equals(name))
                                Console.WriteLine($"    DNA: {p.DNA} – Original");
                        }
                        foreach (var pe in PersonEvolutionList)
                        {
                            if (pe.p.name.Equals(name))
                                Console.WriteLine($"    DNA: {pe.p.DNA} – {pe.From} to {pe.To}");
                        }
                        break;
                    case 3: Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Input!");
                        break;
                }
            }


        }
    }
}
