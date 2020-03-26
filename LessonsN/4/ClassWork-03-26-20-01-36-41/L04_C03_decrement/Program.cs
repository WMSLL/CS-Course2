using System;

namespace L04_C03_decrement
{
	class Program
	{
		static void Main()
		{
			// decrement

			// --i
			var a = 0;
			var b = 0;
			b = --a; // first decrement "a", then assign its value to "b"
			Console.WriteLine(a);	// -1
			Console.WriteLine(b);	// -1

			// i--
			var c = 0;
			var d = 0;
			d = c--; // first assign value of "c" to "d", then decrement "c"
			Console.WriteLine(c);	// -1
			Console.WriteLine(d);	// 0
		}
	}
}