using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Set<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public void AddItem(T value)
        {
            list.AddLast(value);
        }
        public void Search(T key)
        {
            if (list.Contains(key))
                Console.WriteLine($"{key} is present in the list");
            else
                Console.WriteLine($"{key} is not present in the list");


        }
        public static T GetTfromString<T>(string mystring)
        {
            var foo = TypeDescriptor.GetConverter(typeof(T));
            return (T)(foo.ConvertFromInvariantString(mystring));
        }
    }
}
