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
            string BookId, Title, Author;
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("1. Add a Book to Library");
                Console.WriteLine("2. Display available Books by topic");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter a choice:");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("Enter book id:");
                        BookId = Console.ReadLine();
                        Console.WriteLine("Enter book title:");
                        Title = Console.ReadLine();
                        Console.WriteLine("Enter author of the book:");
                        Author = Console.ReadLine();
                        Console.WriteLine("Enter topics:\nType Q to stop adding topic");
                        List<string> topics = new List<string>();
                        string topic;
                        while (true)
                        {
                            topic = Console.ReadLine();
                            if (topic.Equals("Q"))
                                break;
                            topics.Add(topic);
                        }
                        library.books.Add(new Book(BookId,Title,Author,topics));
                        break;
                    case 2:
                        Console.WriteLine("Enter topic to browse books:");
                        string t = Console.ReadLine(); 
                        var sortedList = from book in library.books
                                         where book.topics.Contains(t)
                                         orderby book.Title
                                         select book;
                        foreach (var book in sortedList)
                        {
                            book.printDetails();
                        }
                        break;
                }
            }
            

        }
    }
}
