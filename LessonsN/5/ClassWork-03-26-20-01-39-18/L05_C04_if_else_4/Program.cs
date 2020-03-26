using System;

namespace L05_C04_if_else_4
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a number less than 1000:");
			var strNum = Console.ReadLine();
			var num = int.Parse(strNum);
			string message;

			if (num < 100)
			{
				message = "Correct number!";
			}
			else if (num >= 100 && num < 1000)
			{
				message = "Correct but very big number!";
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