using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    class Book
    {
        public string BookId, Title, Author;
        public List<string> topics;
        public Book()
        {

        }
        public Book(string BookId,string Title,string Author,List<string> topics)
        {
            this.BookId = BookId;
            this.Title = Title;
            this.Author = Author;
            this.topics = topics;
        }
        public void printDetails()
        {
            Console.Write($"Title: {Title}\tBookId: {BookId}\tAuthor: {Author}\tTopics: ");
            foreach (var topic in topics)
            {
                Console.Write($"{topic}, ");
            }
            Console.WriteLine();
        }
    }
}
