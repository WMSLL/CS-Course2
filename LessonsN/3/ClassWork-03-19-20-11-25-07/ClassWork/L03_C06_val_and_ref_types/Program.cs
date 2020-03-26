using System;

class Program
{
	static void Main()
	{
		// FIFO
		// First In First Out
		// LIFO
		// Last In First Out

		// Stack       (Стэк)
		// Heap  	   (Куча)
		// Application (Сегмент кода)

		int a = 0;
		string name = new string('c', 1000);

		Console.WriteLine($"{default(int)}");  // 0
		Console.WriteLine($"{default(bool)}"); // False
		Console.WriteLine($"{default(DateTime)}"); // 1/01/0001 00:00:00
		Console.WriteLine($"{default(string)}"); // ???
	}
}