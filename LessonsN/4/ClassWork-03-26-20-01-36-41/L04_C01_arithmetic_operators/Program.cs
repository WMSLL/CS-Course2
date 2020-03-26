using System;

namespace L04_C01_arithmetic_operators
{
	class Program
	{
		static void Main()
		{
			// var resultVariable = firstOperand operator secondOperand; // result
			var a = 7 + 0.5F;		// 7.5
			Console.WriteLine(a);

			var b = 7 - 2;          // 5
			Console.WriteLine(b);

			var c = 10.1F * 3;    // 30.3
			Console.WriteLine(c);

			var d = 11 / 3;         // 3
			Console.WriteLine(d);

			double e = 11 / 3;      // 3
			Console.WriteLine(e);

			var f = 11.0 / 3;    // 3.66666666666667
			Console.WriteLine(f);

			var g = 11 % 3;         // 2
			Console.WriteLine(g);
		}
	}
}