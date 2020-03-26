using System;

namespace L04_C07_type_inplicit_casting
{
	class Program
	{
		static void Main()
		{
			var a = 10;
			double b = a;
			Console.WriteLine(b);

			var g = 9.8;
			// int c = g; // compiler gives an error for this line!
			Console.WriteLine(g);
		}
	}
}