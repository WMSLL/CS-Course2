using System;

namespace L05_C07_unsafe_code
{
	class Program
	{
		static void Main()
		{
			// for example, we would like to create a simple calculator
			Console.WriteLine("Enter integer value A: ");
			var first = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter integer value B: ");
			var second = int.Parse(Console.ReadLine());

			var result = first / second;

			Console.WriteLine($"{first} divide by {second} equals to {result}");
			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}