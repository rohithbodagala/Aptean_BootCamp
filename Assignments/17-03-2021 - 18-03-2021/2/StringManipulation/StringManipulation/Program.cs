using System;
using System.Text;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the First String: ");
            var s1 = Console.ReadLine();
            Console.Write("Enter the Second String: ");
            var s2 = Console.ReadLine();
            var count = 0;
            foreach(var ch in s1)
            {   
                if(ch=='a' || ch=='A')
                {
                    count++;
                }
            }
            foreach (var ch in s2)
            {
                if(ch == 'a' || ch == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of occurences of 'a' and 'A' in the given strings are {count}");
            s1 = s1.Replace('a', '@');
            s1 = s1.Replace('A', '@');
            s2 = s2.Replace('a', '@');
            s2 = s2.Replace('A', '@');
            s1 = s1.ToUpper();
            s2 = s2.ToUpper();
            Console.WriteLine($"String after concatenating: {String.Concat(s1, s2)}");
            StringBuilder sb1 = new StringBuilder("Aptean");
            Console.WriteLine($"The string taken in StringBuilder variable is: {sb1.ToString()}");
            sb1.Append("Company");
            sb1.Insert(13,"India");
            sb1.Remove(6,7);
            sb1.Replace('n','k');
            count = 0;
            foreach (var ch in sb1.ToString())
            {
                if (ch == 'a' || ch == 'A')
                {
                    count++;
                }
            }
            Console.WriteLine($"The number of occurences of 'a' and 'A' in the given string is {count}");
            sb1.Replace('a', '@');
            sb1.Replace('A', '@');
            Console.WriteLine($"Performing operations on StringBuilder variable: {String.Concat(s1,sb1.ToString().ToUpper())}");



        }
    }
}