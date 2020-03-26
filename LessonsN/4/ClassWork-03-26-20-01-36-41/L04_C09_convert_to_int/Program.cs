using System;

namespace L04_C09_convert_to_int
{
	class Program
	{
		static void Main()
		{
			var i = 9.49;
			var j = 9.5;
			var k = 10.49;
			var l = 10.5; // it will be just 10!
			var m = 10.51;
			Console.WriteLine(Convert.ToInt32(i)); // 9
			Console.WriteLine(Convert.ToInt32(j)); // 10
			Console.WriteLine(Convert.ToInt32(k)); // 10
			Console.WriteLine(Convert.ToInt32(l)); // 10
			Console.WriteLine(Convert.ToInt32(m)); // 11

			Console.WriteLine(Math.Round(i, MidpointRounding.ToEven)); // 9
			Console.WriteLine(Math.Round(j)); // 10
			Console.WriteLine(Math.Round(k)); // 10
			Console.WriteLine(Math.Round(l)); // 10
			Console.WriteLine(Math.Round(m)); // 11
		}
	}
}