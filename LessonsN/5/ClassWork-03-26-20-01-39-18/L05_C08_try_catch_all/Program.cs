using System;

namespace L05_C08_try_catch_all
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
			catch // catching ALL exceptions is a bad practice as it may hide problems!
			{
				Console.WriteLine("Can't continue calculation! Something goes wrong!");
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}