using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SetOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string file = @"..\..\..\WordList1.txt";
            var lines = File.ReadAllLines(file);
            var WordList1 = new List<String>();
            foreach (var line in lines)
            {
                WordList1.Add(line.Trim());
            }
            
            file = @"..\..\..\WordList2.txt";
            lines = File.ReadAllLines(file);
            var WordList2 = new List<String>();
            foreach (var line in lines)
            {
                WordList2.Add(line.Trim());
            }
            var res1 = from word in WordList1.Except(WordList2)
                       select word;
            Console.WriteLine("\nWords present in first list and not in the second list:\n");
            foreach(var word in res1)
            {
                Console.Write($"{word}, ");
            }
            Console.WriteLine();
            var res2 = from word in WordList2.Except(WordList1)
                       select word;
            Console.WriteLine("\nWords present in second list and not in the first list:\n");
            foreach (var word in res2)
            {
                Console.Write($"{word}, ");
            }
            Console.WriteLine();
            var res3 = from word in WordList1.Intersect(WordList2)
                       select word;
            Console.WriteLine("\nCommon words in both the dictionary:\n");
            foreach (var word in res3)
            {
                Console.Write($"{word}, ");
            }


        }
    }
}
