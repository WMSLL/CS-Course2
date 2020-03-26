using System;

namespace L05_C09_try_catch_with_details
{
	class Program
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Enter integer value A: ");
				var first = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter integer value B: ");
				var second = int.Parse(Console.ReadLine());

				var result = first / second;
				Console.WriteLine($"{first} divide by {second} equals to {result}");
			}
			catch (Exception exception)
			{
				Console.WriteLine("Can't continue calculation:");
				Console.WriteLine($"{exception.GetType()}: {exception.Message}");
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}