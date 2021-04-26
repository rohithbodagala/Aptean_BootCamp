using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

/// <summary>
/// This is a sample project which has the functionality of serializing / deserializing objects of Student/Book Types.
/// Your team lead has spotted a problem in implementation approach of XMLSerializerWrapper class. 
/// What is the problem? How do you solve it?
/// </summary>

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            XMLSerializerWrapper wrapperObj = new XMLSerializerWrapper();

            #region Serialize/Deserialize Student
            var student = new Student() { StudentId = "1CS18AQ001", Firstname = "Raj", LastName = "Kapoor" };
            var filePathStudent = Path.GetTempFileName();

            //Serialize Student
            wrapperObj.Serialize<Student>(student, filePathStudent);

            //Deserialize Student
            var studentObjDeserialized = wrapperObj.Deserialize<Student>(filePathStudent);
            Console.WriteLine($"StudentID: {studentObjDeserialized.StudentId} , FirstName: {studentObjDeserialized.Firstname}, LastName:{studentObjDeserialized.LastName}");

            #endregion

            #region Serialize/Deserialize Book
            var book = new Book() { BookId = "AB566", Author = "Andrew", Title = "Learn C#" };
            var filePathBook = Path.GetTempFileName();

            //Serialize Book
            wrapperObj.Serialize<Book>(book,filePathBook);

            //Deserialize Book
            var bookObjDeserialized = wrapperObj.Deserialize<Book>(filePathBook);
            Console.WriteLine($"BookId: {bookObjDeserialized.BookId}, Author: {bookObjDeserialized.Author}, Title: {bookObjDeserialized.Title}");

            #endregion

            Console.ReadLine();

        }

    }


}
