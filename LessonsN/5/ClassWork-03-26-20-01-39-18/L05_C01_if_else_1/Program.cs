using System;

namespace L05_C01_if_else_1
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Press any key for analysis:");
			var c = Console.ReadKey(true).KeyChar;

			if (char.IsLetterOrDigit(c))
			{
				Console.WriteLine("You entered letter or digit!");
			}
			else
			{
				Console.WriteLine("You pressed a strange key...");
			}

			Console.WriteLine("Press any key to exit...");
			Console.ReadKey();
		}
	}
}