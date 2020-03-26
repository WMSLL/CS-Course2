using System;

namespace L05_C11_try_catch_final
{
	class Program
	{
		static void Main()
		{
			var first = ReadInt("A");
			var second = ReadInt("B");

			try
			{
				var result = first / second;
				WriteWithColor($"The number {first} divide by {second} equals to {result}", ConsoleColor.Green);
			}
			catch (DivideByZeroException ex)
			{
				WriteWithColor("Fatal error occured", ConsoleColor.Red);
				WriteWithColor(ex.Message, ConsoleColor.Red);
			}

			WriteWithColor("Press any key to exit...", ConsoleColor.Yellow);
			Console.ReadKey();
		}

		static int ReadInt(string name)
		{
			while (true)
			{
				try
				{
					Console.WriteLine($"Enter integer value {name}");
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