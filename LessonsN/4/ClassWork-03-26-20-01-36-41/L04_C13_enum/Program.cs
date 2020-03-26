using System;

namespace L04_C13_enum
{
	enum Day
	{
		Sunday,
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday
	}

	enum Month : byte
	{
		Jan,
		Feb,
		Mar,
		Apr,
		May,
		Jun,
		Jul,
		Aug,
		Sep,
		Oct,
		Nov,
		Dec
	}

	class Program
	{
		public static void Main()
		{
			var today = Day.Monday;
			var dayNumber = (int) today;
			Console.WriteLine("{0} is day number #{1}.", today, dayNumber);

			var thisMonth = Month.Dec;
			var monthNumber = (byte) thisMonth;
			Console.WriteLine("{0} is month number #{1}.", thisMonth, monthNumber);

			// Monday is day number #1.
			// Dec is month number #11.
		}
	}
}