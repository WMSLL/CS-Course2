using System;

namespace L05_C00_enum_methods
{
	[Flags]
	enum ColorPallet : short
	{
		None = 0x0,
		Black = 0x1,
		Blue = 0x1 << 1,
		Cyan = 0x1 << 2,
		Grey = 0x1 << 3,
		Green = 0x1 << 4,
		Magenta = 0x1 << 5,
		Red = 0x1 << 6,
		White = 0x1 << 7,
		Yellow = 0x1 << 8,
	}

	class Program
	{
		static void Main(string[] args)
		{
			var colors = GetColors();
			Display("Available colors", colors);

			var favoriteColors = ReadFavoriteColors();
			Display("Favorite colors for user", favoriteColors);

			var remainingColors = colors ^ favoriteColors;
			Display("Remaining colors", remainingColors);

			Console.ReadKey();
		}

		static ColorPallet ReadFavoriteColors()
		{
			var colors = ColorPallet.None;

			for (var i = 0; i < 4; i++)
			{
				var color = ReadColor(i);
				colors |= color;
			}

			return colors;
		}

		static ColorPallet ReadColor(int number)
		{
			while (true)
			{
				WriteWithColor($"Please, enter your favorite color, number {number}: ", ConsoleColor.White);

				var input = Console.ReadLine();
				if (Enum.TryParse(typeof(ColorPallet), input, out var result) && (ColorPallet)result > 0)
				{
					return (ColorPallet)result;
				}

				WriteLineWithColor("Wrong value for color!", ConsoleColor.Red);
			}
		}

		static ColorPallet GetColors()
		{
			var result = ColorPallet.None;
			var values = (ColorPallet[])Enum.GetValues(typeof(ColorPallet));

			for (var i = 0; i < values.Length; i++)
			{
				result = result | values[i];
			}

			return result;
		}

		static void Display(string header, ColorPallet color)
		{
			WriteLineWithColor(header, ConsoleColor.Green);

			for (int shift = 0, order = 0; shift < sizeof(short) * 8; shift++)
			{
				var value = (short)(0x1 << shift);

				if (((short)color & value) == value)
				{
					WriteWithColor((++order).ToString(), ConsoleColor.Yellow);
					WriteWithColor(" has byte position", ConsoleColor.White);
					WriteWithColor($" {shift}", ConsoleColor.Red);
					WriteWithColor(" and byte binary value", ConsoleColor.White);
					WriteWithColor($" {Convert.ToString(value, 2).PadLeft(16, '0')}", ConsoleColor.Red);
					WriteWithColor(" and pallet color is", ConsoleColor.White);
					WriteLineWithColor($" {(ColorPallet)value}", ConsoleColor.Red);
				}
			}
		}

		static void WriteWithColor(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.Write(message);
			Console.ForegroundColor = restoreColor;
		}

		static void WriteLineWithColor(string message, ConsoleColor color)
		{
			var restoreColor = Console.ForegroundColor;
			Console.ForegroundColor = color;
			Console.WriteLine(message);
			Console.ForegroundColor = restoreColor;
		}
	}
}