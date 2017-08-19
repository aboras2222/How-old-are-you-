using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime MyAge;
			Console.Write("Enter your Birthday in Form DD/MM/YYYY:");
			MyAge=Convert.ToDateTime(Console.ReadLine());
			int year = Convert.ToInt32(DateTime.Now.Subtract(MyAge).TotalDays) / 360;
			Console.WriteLine("your Age is :" + year + "year");
			
			
			Console.ReadKey();

		}
	}
}
