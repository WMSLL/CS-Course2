using System;

namespace L05_C02_if_else_2
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a number less than 100:");
			var strNum = Console.ReadLine();
			var num = int.Parse(strNum);
			string message;

			if (num < 100)
			{
				message = "Correct!";
			}
			else
			{
				message = "Error!";
			}

			Console.WriteLine(message + " Press any key to exit...");
			Console.ReadKey();
		}
	}
}