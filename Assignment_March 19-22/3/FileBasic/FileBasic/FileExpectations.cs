using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace FileBasic
{

    class FileExpectations
    {
        List<string> files = new List<string>();
        string FileName = "";
        

        
        static void Main(string[] args)
        {
            CollectionMgr obj = new CollectionMgr();
            char choice = new char();
            do
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("\t1.Add new file to collection");
                Console.WriteLine("\t2.Delete a given file from collection");
                Console.WriteLine("\t3.Count of words in a file");
                Console.WriteLine("\t4.Count of words in all files");


                int select = int.Parse(Console.ReadLine());
                switch (select)
                {
                    case 1:
                        Console.WriteLine("Enter the file name to create:");
                        string fname = Console.ReadLine();
                        obj.AddFile(fname);
                            break;
                    case 2:
                        obj.getFilesFromDirectory();
                        Console.WriteLine("enter the file name to delete");
                        fname = Console.ReadLine();
                        obj.RemoveFile(fname);
                            break;
                    case 3:
                        obj.getFilesFromDirectory();
                        Console.WriteLine("Please enter the file name");
                            fname = Console.ReadLine();
                        obj.GetTotalWordsInAFile(fname);
                        break;
                    case 4:
                            Console.WriteLine("Total Word in all the files are ");
                            obj.GetTotalWordsInAllFiles();
                            break;
                    default: break;
                }
                Console.WriteLine(" Do you want to exit?  (Y/N)");
                choice = char.Parse(Console.ReadLine());
            } while (choice != 'Y');
        }
    }


}


