using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LibraryManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("1. Add a Book to Library");
                Console.WriteLine("2. Display available Books by topic");
                Console.WriteLine("3. Return Book");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Enter a choice:");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.BrowseBooks();
                        library.checkBorrow();
                        break;
                    case 3:
                        library.returnBook();
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            

        }
    }
}
