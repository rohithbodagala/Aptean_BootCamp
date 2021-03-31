using System;

namespace Catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            Music[] music =  new Music[10];
            music[0] = new Music("Dangerous","M01",Category.Music,3.5,"Michael Jackson",215);
            music[1] = new Music("Sunshine","M02",Category.Music,3.7,"Ronald",194);
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine(music[i].RetrieveInformation());
            }
            

            Film[] films = new Film[10];
            films[0] = new Film("Magadheera","F01",Category.Film,720,"Rajmouli","Ram Charan","Kajal Agarwal");
            films[1] = new Film("Arya","F02",Category.Film,762,"Sukumar", "Allu Arjun", "Tamannah Bhatia");
            for(var i=0;i<2;i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine(films[i].RetrieveInformation());
            }
            ComputerProgram[] programs = new ComputerProgram[10];
            programs[0] = new ComputerProgram("Program.cs", "CP01", Category.ComputerProgram, 0.2);
            programs[1] = new ComputerProgram("Test.cs", "CP02", Category.ComputerProgram, 0.19);
            for (var i = 0; i < 2; i++)
            {
                Console.WriteLine("******************************************");
                Console.WriteLine(programs[i].RetrieveInformation());
            }

        }
            
    }
}
