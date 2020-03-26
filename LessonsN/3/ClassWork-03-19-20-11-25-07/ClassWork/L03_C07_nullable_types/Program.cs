using System;

class Program
{
	static void Main()
	{
		int? b; // the same as a
		Nullable<Int32> a = null;
		Nullable<Int32> c = 10;

		// Console.WriteLine(a.Value); // <Exception>
		Console.WriteLine(a.HasValue); // <False>
		Console.WriteLine(a.GetValueOrDefault()); // <0>
		Console.WriteLine(c.HasValue); // <True>
		Console.WriteLine(c.Value); // <10>
		Console.WriteLine(c.GetValueOrDefault()); // <10>
		a = 4;
		Console.WriteLine(a); // 4
	}
}