using System;

namespace L05_C06_throw_exception
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Enter a number less than 100:");
			var number = int.Parse(Console.ReadLine());
			if (number >= 100)
			{
				throw new Exception("The value should be less than 100!");
			}

			Console.WriteLine($"You entered correct value {number}");
			Console.ReadKey();
		}
	}
}