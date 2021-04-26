using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Library
    {
        public List<Book> books;
        public Dictionary<string,BorrowCard> borrowCards;
        public Dictionary<string,Queue<string>> bookqueue;
        public Library()
        {
            books= new List<Book>();
            borrowCards = new Dictionary<string, BorrowCard>();
            bookqueue = new Dictionary<string, Queue<string>>();
        }
        public void AddBook()
        {
            Console.WriteLine("Enter book id:");
            string BookId = Console.ReadLine();
            Console.WriteLine("Enter book title:");
            string Title = Console.ReadLine();
            Console.WriteLine("Enter author of the book:");
            string Author = Console.ReadLine();
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
            books.Add(new Book(BookId, Title, Author, topics));
        }
        public void BrowseBooks()
        {
            Console.WriteLine("Enter topic to browse books:");
            string t = Console.ReadLine();
            var sortedList = from book in books
                             where book.topics.Contains(t)
                             orderby book.Title
                             select book;
            foreach (var book in sortedList)
            {
                book.printDetails();
            }
        }
        public void EnterWaitList(string bid,string sid)
        {
            Console.WriteLine("Book is already borrowed.Do you want to enter into the waitlist?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                if (!bookqueue.ContainsKey(bid))
                    bookqueue.Add(bid, new Queue<string>());
                bookqueue.GetValueOrDefault(bid).Enqueue(sid);
                Console.WriteLine("Joined Waitlist!");
                
            }
            
            
        }
        public void borrowBook(string bid,string sid)
        {
            if (borrowCards.ContainsKey(bid))
            {
                borrowCards.GetValueOrDefault(bid).studentId = sid;
                borrowCards.GetValueOrDefault(bid).dateBorrowed = DateTime.Now;
                borrowCards.GetValueOrDefault(bid).dateReturned = null;

            }
            else
            {
                borrowCards.Add(bid, new BorrowCard(sid, DateTime.Now, null));
            }
                
        }
        public void checkBorrow()
        {
            Console.WriteLine("Enter Book ID to borrow:");
            string bid = Console.ReadLine();
            Console.WriteLine("Enter Student ID: ");
            string sid = Console.ReadLine();
            if (borrowCards.ContainsKey(bid))
            {
                DateTime? d1 = borrowCards.GetValueOrDefault(bid).dateReturned;
                if(d1==null)
                    EnterWaitList(bid,sid);
            }
            else
            {
                borrowBook(bid,sid);
            }
            
        }
        public void returnBook()
        {
            Console.WriteLine("Enter Book ID:");
            string bid = Console.ReadLine();
            Console.WriteLine("Enter Student ID:");
            string sid = Console.ReadLine();
            if (borrowCards.GetValueOrDefault(bid).studentId.Equals(sid))
            {
                borrowCards.GetValueOrDefault(bid).dateReturned = DateTime.Now;
                Console.WriteLine("Book returned!");
                if (bookqueue.ContainsKey(bid))
                {
                    if (bookqueue.GetValueOrDefault(bid).Count != 0)
                    {
                        Console.WriteLine($"Lending Book {bid} to Student {bookqueue.GetValueOrDefault(bid).Dequeue()}");
                    }
                }
                

            }
        }
    }
}
