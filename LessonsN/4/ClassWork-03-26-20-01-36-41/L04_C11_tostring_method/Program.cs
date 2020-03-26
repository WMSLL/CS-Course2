using System;

namespace L04_C11_tostring_method
{
	class Program
	{
		static void Main()
		{
			var number = 12;
			Console.WriteLine(number.ToString());	// 12

			var boolean = true;
			Console.WriteLine(boolean.ToString());	// True

			var now = DateTime.Now;
			Console.WriteLine(now.ToString());		// 1/1/2019 2:15:00 PM

			var me = new object();
			Console.WriteLine(me.ToString());		// System.Object

			var str = "abc";
			Console.WriteLine(str.ToString());		// abc :)
		}
	}
}