using System;

namespace L04_C04_logical_negation
{
	class Program
	{
		static void Main()
		{
			var a = true;
			Console.WriteLine(a);	// a is "true"

			var b = !a;
			Console.WriteLine(b);	// a is "true", so !a is "false"

			var c = !b;			
			Console.WriteLine(c);	// b is "false", so !b is "true"
		}
	}
}