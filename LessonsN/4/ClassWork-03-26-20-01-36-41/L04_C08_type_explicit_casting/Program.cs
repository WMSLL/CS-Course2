using System;

namespace L04_C08_type_explicit_casting
{
	class Program
	{
		static void Main()
		{
			var c = 9.8;
			var d = (int)c; // 'g' is 9 loosing its .8 part
			Console.WriteLine(d);

			long e = 10;
			var f = (int)e;
			Console.WriteLine($"e is {e} and f is {f}"); // e is 10 and f is 10

			e = long.MaxValue;
			f = (int)e;
			Console.WriteLine($"e is {e} and f is {f}");	// e is 9223372036854775807 and f is -1
		}
	}
}