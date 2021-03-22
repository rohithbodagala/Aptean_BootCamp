using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
namespace FileBasic
{
    class CollectionMgr
    {
        string FileName = "";
        List<string> FilesCollection;
        public CollectionMgr()
        {
            string name = "";
            FilesCollection = new List<string>();
            string[] files = Directory.GetFiles(@"..\..\..\Files");
            foreach(var file in files)
            {
                name = file.Substring(15);
                FilesCollection.Add(name);
            }

        }
        public string getFilePath(string fname)
        {
            return ConfigurationManager.AppSettings["root"].ToString() + fname;
        }
        public void getFilesFromDirectory()
        {
            foreach(var file in FilesCollection)
            {
                Console.WriteLine(file);
            }
        }
        public void AddFile(string fname)
        {
            FileName = "";
            
            try
            {
                int charPos = fname.IndexOf(".");
                string ext = fname.Substring(charPos + 1);
                if (!ext.Equals("txt"))
                {
                    throw new Exception();
                }
                FileName += getFilePath(fname);
                StreamWriter sw = new StreamWriter(FileName);
                FilesCollection.Add(fname);
                Console.WriteLine("Enter the Text that you want to write to the File:");
                string str = Console.ReadLine();
                sw.WriteLine(str);
                sw.Flush();
                sw.Close();
                    
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Invalid File Extension!");
            }



        }

        public void RemoveFile(string fname)
        {
            FileName = "";
            FileName += getFilePath(fname);
            if (isValidFile(FileName))
            {
                File.Delete(FileName);
                FilesCollection.Remove(fname);
            }

        }
        public int getCount(string FileName)
        {
            int counter = 0;
            StreamReader sr = new StreamReader(FileName);

            string delim = " ,.";
            string[] fields = null;
            string line = null;

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                line.Trim();
                fields = line.Split(delim.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                counter += fields.Length;
            }
            sr.Close();
            return counter;
        }


        public void GetTotalWordsInAFile(string fname)
        {

            FileName = getFilePath(fname);
            if (isValidFile(FileName))
            {
                Console.WriteLine($"The word count is {getCount(FileName)}");
                
                
            }


        }

        public void GetTotalWordsInAllFiles()
        {
            int TotalWord = 0;
            foreach (string file in FilesCollection)
            {
                FileName = getFilePath(file);
                TotalWord += getCount(FileName);
            }
            Console.WriteLine(TotalWord);

        }
        public bool isValidFile(string FileName)
        {
            try
            {
                if (!File.Exists(FileName))
                {
                    throw new FileNotFoundException();
                }
                return true;
            }
            catch
            {
                Console.WriteLine("Error: File Does not Exist!");
                return false;
            }
            

        }
    }

}