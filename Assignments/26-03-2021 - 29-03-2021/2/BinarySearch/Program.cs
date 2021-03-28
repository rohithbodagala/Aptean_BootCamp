using System;
using System.Collections.Generic;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the type of data to be inserted:");
            var type = Console.ReadLine();
            Console.WriteLine("Enter the number of items:");
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the items to add to the list:");
            switch (type)
            {
                case "int":
                    var IntObj = new Set<int>();
                    for(int i = 0; i < n; i++)
                    {
                        IntObj.AddItem(int.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Enter the number to search:");
                    IntObj.Search(int.Parse(Console.ReadLine()));
                    break;
                case "char":
                    var CharObj = new Set<char>();
                    for (int i = 0; i < n; i++)
                    {
                        CharObj.AddItem(char.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Enter the character to search:");
                    CharObj.Search(char.Parse(Console.ReadLine()));
                    break;
                case "string":
                    var StringObj = new Set<string>();
                    for (int i = 0; i < n; i++)
                    {
                        StringObj.AddItem(Console.ReadLine());
                    }
                    Console.WriteLine("Enter the string to search:");
                    StringObj.Search(Console.ReadLine());
                    break;
                case "float":
                    var FloatObj = new Set<float>();
                    for (int i = 0; i < n; i++)
                    {
                        FloatObj.AddItem(float.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Enter the float data to search:");
                    FloatObj.Search(float.Parse(Console.ReadLine()));
                    break;
                case "double":
                    var DoubleObj = new Set<double>();
                    for (int i = 0; i < n; i++)
                    {
                        DoubleObj.AddItem(double.Parse(Console.ReadLine()));
                    }
                    Console.WriteLine("Enter the double data to search:");
                    DoubleObj.Search(double.Parse(Console.ReadLine()));
                    break;
            }
            


        }
    }
}
