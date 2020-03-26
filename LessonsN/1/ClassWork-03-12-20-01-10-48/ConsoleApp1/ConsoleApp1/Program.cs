using System;
using System.Threading;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the name: ");
			string name;
			name = Console.ReadLine();
			Thread.Sleep(5 * 1000);

			Console.WriteLine("Hello, " + name);
			Console.WriteLine("Hello, {0} {1}", name, 1);
			Console.WriteLine(string.Format("Hello, {0} {1}", name, 1));
			Console.WriteLine($"Hello, {name}");
			Console.ReadKey();
		}
	}
}