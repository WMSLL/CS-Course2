using System;

namespace L04_C02_increment
{
	class Program
	{
		static void Main()
		{
			// increment

			// ++i
			var a = 0;
			var b = 0;
			b = ++a; // first increment "a", then assign its value to "b"
			Console.WriteLine(a);	// 1
			Console.WriteLine(b);	// 1

			// i++
			var c = 0;
			var d = 0;
			d = c++; // first assign value of "c" to "d", then increment "c"
			Console.WriteLine(c);	// 1
			Console.WriteLine(d);	// 0
		}
	}
}