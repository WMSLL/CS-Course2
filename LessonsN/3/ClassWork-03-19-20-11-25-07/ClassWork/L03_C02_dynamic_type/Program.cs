using System;

class Program
{
	static void Main()
	{
		dynamic name = "1000";
		Console.WriteLine(name.Length); // 4
		name = 10;
		Console.WriteLine(name + 1);	// 11
		name = "100";
		Console.WriteLine(name + 1);	// 1001
	}
}