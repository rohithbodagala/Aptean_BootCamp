using System;
namespace Person
{
	public class Teacher : Person
	{
		private string subject;
		public override void greet()
		{
			Console.WriteLine("Hi all I am your teacher");
		}
		public void explain()
		{
			Console.WriteLine("Explanation begins");
		}
	}
}

