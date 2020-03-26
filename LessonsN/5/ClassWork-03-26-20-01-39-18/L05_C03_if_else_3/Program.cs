using System;

namespace L05_C03_if_else_3
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a number less than 100:");
			var line = Console.ReadLine();
			var number = int.Parse(line);
			var message = number < 100
				? "Correct!"
				: "Error!";

			Console.WriteLine(message + " Press any key to exit...");
			Console.ReadKey();
		}
	}
}
