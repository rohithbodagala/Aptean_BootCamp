using System;
namespace Person
{
    public class Student : Person

    {
        public override void greet()
        {
            Console.WriteLine("Hi all,I am a student");
        }
        public void goToClasses()
        {
            Console.WriteLine("I'm going to classes");
        }
        public void showAge()
        {
            Console.WriteLine($"My age is: {Age} years old");
        }
    }
}

