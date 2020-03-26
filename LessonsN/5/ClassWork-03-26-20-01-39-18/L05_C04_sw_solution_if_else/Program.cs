using System;

namespace L05_C04_sw_solution_if_else
{
	// Самостоятельная работа:
	// С консоли вводится число, от 1 до 100
	// Необходимо:
	// Считать это число 
	// И вывести грамматически корректную фразу
	// 1, 21, .. 91 => <число> год
	// 2-4, 22-24, .. 92-94 => <число> года
	// 5-20, 25-30, .. 95-99 => <число> лет
	// Если возраст больше 100 => вывести ошибку

	class Program
	{
		static void Main()
		{
			Console.Write("Введите возраст: ");
			var age = int.Parse(Console.ReadLine());
			var reminder = age % 10;
			var decimals = age / 10;

			if (age < 1 || age > 99)
			{
				Console.WriteLine("Введено значение больше 99");
			}
			else if (reminder == 1 && decimals != 1)
			{
				Console.WriteLine($"Возраст: {age} год");
			}
			else if (reminder >= 2 && reminder <= 4 && decimals != 1)
			{
				Console.WriteLine($"Возраст: {age} года");
			}
			else
			{
				Console.WriteLine($"Возраст: {age} лет");
			}

			Console.ReadKey();
		}
	}
}