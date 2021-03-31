using System;
namespace Person
{
    public class Person
    {
        public int Age;
        public virtual void greet()
        {
            Console.WriteLine("Hello everyone");
        }
        public void setage(int n)
        {
            Age = n;
        }

    }
}
    

