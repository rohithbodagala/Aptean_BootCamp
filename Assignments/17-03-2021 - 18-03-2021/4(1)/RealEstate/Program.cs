using System;

namespace RealEstate
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2500, 4, 2);
            Building office = new Building(4200, 25, 3);
            Console.WriteLine($"Area of house = {house.printArea()}");
            Console.WriteLine($"Occupants of house = {house.occupants}");
            Console.WriteLine($"Floors of house = {house.floors}");
            Console.WriteLine($"Area per person in house = {house.CalculateAreaPerPerson()}\n");

            Console.WriteLine($"Area of office = {office.printArea()}");
            Console.WriteLine($"Occupants of office = {office.occupants}");
            Console.WriteLine($"Floors of office = {office.floors}");
            Console.WriteLine($"Area per person in office = {office.CalculateAreaPerPerson()}");
        }
    }
}
