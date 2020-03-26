using System;

namespace L05_C10_try_catch_parsing
{
	class Program
	{
		static void Main()
		{
			var first = ReadInt("Enter first integer value: ");
			var second = ReadInt("Enter second integer value: ");
			var result = first / second;

			WriteWithColor($"The number {first} divide by {second} equals to {result}", ConsoleColor.Green);
			WriteWithColor("Press any key to exit...", ConsoleColor.Yellow);
			Console.ReadKey();
		}

		static int ReadInt(string title)
		{
			while (true)
			{
				try
				{
					Console.WriteLine(title);
					return int.Parse(Console.ReadLine());
				}
				catch (FormatException exception)
				{
					WriteWithColor("Entered incorrect data!", ConsoleColor.Red);
					WriteWithColor(exception.Message, ConsoleColor.Red);
				}
				catch (OverflowException exception)
				{
					WriteWithColor("Entered unsupported value", ConsoleColor.Red);
					WriteWithColor(exception.Message, ConsoleColor.Red);
				}
			}
		}

		static void WriteWithColor(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = restoreColor;
		}
	}
}