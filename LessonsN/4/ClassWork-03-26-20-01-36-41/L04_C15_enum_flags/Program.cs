using System;

namespace L04_C15_enum_flags
{
	[Flags]
	enum Days: byte
	{
		None = 0x0,
		Sunday = 0x1,
		Monday = 0x1 << 1,
		Tuesday = 0x1 << 2,
		Wednesday = 0x1 << 3,
		Thursday = 0x1 << 4,
		Friday = 0x1 << 5,
		Saturday = 0x1 << 6
	}

	class Program
	{
		static void Main(string[] args)
		{
			var nonWorkingDays = Days.Saturday | Days.Sunday;
			WriteByteValueWithBits((byte)Days.Saturday);
			WriteByteValueWithBits((byte)Days.Sunday);
			WriteByteValueWithBits((byte)nonWorkingDays);

			Console.WriteLine("\nAdding Friday:");

			// add Friday to the list of non-working days
			nonWorkingDays = nonWorkingDays | Days.Friday;
			WriteByteValueWithBits((byte)Days.Friday);
			WriteByteValueWithBits((byte)nonWorkingDays);

			Console.WriteLine("\nRemove Sunday:");

			// remove Sunday from the list of non-working days
			WriteByteValueWithBits((byte)nonWorkingDays);
			WriteByteValueWithBits((byte)Days.Sunday);
			nonWorkingDays = nonWorkingDays ^ Days.Sunday;
			WriteByteValueWithBits((byte)nonWorkingDays);

			Console.WriteLine("\nCheck Thursday:");
			WriteByteValueWithBits((byte)nonWorkingDays);
			WriteByteValueWithBits((byte)Days.Thursday);
			WriteByteValueWithBits((byte)(nonWorkingDays & Days.Thursday));
			var isThursdayNonWirking = (nonWorkingDays &Days.Thursday) == Days.Thursday;
			Console.WriteLine(isThursdayNonWirking);

			Console.WriteLine("\nCheck Friday:");
			WriteByteValueWithBits((byte)nonWorkingDays);
			WriteByteValueWithBits((byte)Days.Friday);
			WriteByteValueWithBits((byte)(nonWorkingDays & Days.Friday));
			var isFridayNonWirking = (nonWorkingDays & Days.Friday) == Days.Friday;
			Console.WriteLine(isFridayNonWirking);
		}

		static void WriteByteValueWithBits(byte value)
		{
			Console.WriteLine(
				"0x{0}\t({1})\t{2}",
				value.ToString("X").PadLeft(2, '0'),
				Convert.ToString(value, 2).PadLeft(8, '0'),
				value.ToString().PadLeft(3, '0'));
		}
	}
}
