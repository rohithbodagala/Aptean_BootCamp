using System;

namespace Person
{
    class StudentAndTeacherTest
    {
		static void Main(string[] args)
		{
			Person person = new Person();
			person.greet();


			Console.WriteLine("---------------------------------------------");
			var student = new Student();
			student.setage(21);
			student.greet();
			student.goToClasses();
			student.showAge();

			Console.WriteLine("---------------------------------------------");

			var teacher = new Teacher();
			teacher.setage(30);
			teacher.greet();
			teacher.explain();



		}
	}
}
