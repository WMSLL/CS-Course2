using System;

namespace L04_C12_parse_method
{
	class Program
	{
		static void Main()
		{
			var strInt = "12";
			var i = Int32.Parse(strInt);
			Console.WriteLine(i * i); // 144

			var strFloat = "3.14159265";
			var f = Single.Parse(strFloat);
			Console.WriteLine(f * 2); // 6.283185

			var strBool = "true";
			var b = Boolean.Parse(strBool);
			Console.WriteLine(b.ToString()); // True
		}
	}
}