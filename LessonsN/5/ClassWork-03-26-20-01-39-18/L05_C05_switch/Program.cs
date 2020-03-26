using System;

namespace L05_C05_switch
{
	enum Color
	{
		Red,
		Green,
		Blue
	}

	class Program
	{
		static void Main()
		{
			var random = new Random();
			var color = (Color) random.Next(0, 10);

			switch (color)
			{
				case Color.Red:
				case Color.Green:
					Console.WriteLine("The color is green");
					break;
				case Color.Blue:
					Console.WriteLine("The color is blue");
					break;
				default:
					Console.WriteLine($"The color {color} is unknown.");
					break;
			}

			// Switch expressions, C# 7.0
			// Позволляют присвоить значение переменной на основе switch меток
			// Можно рассматривать как расширенный аналог тернарных выражений
			var line = color switch
			{
				Color.Red => "The color is red",
				Color.Green => "The color is red",
				Color.Blue => "The color is red",
				_ => $"The color {color} is unknown."
			};

			Console.WriteLine(line);
		}
	}
}