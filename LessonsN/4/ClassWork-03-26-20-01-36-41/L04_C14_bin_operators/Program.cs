using System;

namespace L04_C14_bin_operators
{
	class Program
	{
		static void Main()
		{
			// Binary literals, available since C# 7.0

			byte a = 0b00000011;
			byte b = 0b00000101;

			Console.WriteLine("Binary operations: ");
			WriteLine("A: ", a);
			WriteLine("B: ", b);

			// | OR
			// 1 | 1 = 1
			// 1 | 0 = 1
			// 0 | 1 = 1
			// 0 | 0 = 0

			WriteLine("A | B: ", (byte) (a | b));

			// & AND
			// 1 & 1 = 1
			// 0 & 1 = 0
			// 1 & 0 = 0
			// 0 & 0 = 0

			WriteLine("A & B: ", (byte) (a & b));

			// ^ XOR
			// 0 ^ 0 = 0
			// 0 ^ 1 = 1
			// 1 ^ 0 = 1
			// 1 ^ 1 = 0

			WriteLine("A ^ B: ", (byte) (a ^ b));

			// ~ NOT
			// ~ 1 = 0
			// ~ 0 = 1

			WriteLine("~A: ", (byte) ~a);
			WriteLine("~B: ", (byte) ~b);

			// << left-shift

			WriteLine("A << 1: ", (byte) (a << 1));
			WriteLine("B << 6: ", (byte) (b << 6));

			// >> right-shift

			WriteLine("A >> 1: ", (byte) (a >> 1));
			WriteLine("B >> 2: ", (byte) (b >> 2));

			Console.WriteLine("Binary representation: ");
			CompareBinaryRepresentation(1);
			CompareBinaryRepresentation(2);
			CompareBinaryRepresentation(3);
			CompareBinaryRepresentation(4);
			CompareBinaryRepresentation(100);
		}

		static void WriteLine(string title, byte value)
		{
			var hex = value.ToString("X2").PadLeft(2, '0');
			var binary = Convert.ToString(value, 2).PadLeft(8, '0');
			var original = value.ToString().PadLeft(3, '0');

			Console.Write(title);
			Console.WriteLine($"{binary} (binary) {hex} (hex) {original} (decimal)");
		}

		static void WriteBinaryValue(string title, int value)
		{
			Console.Write(title);
			Console.WriteLine(Convert.ToString(value, 2).PadLeft(32, '0'));
		}

		static void CompareBinaryRepresentation(int value)
		{
			Console.WriteLine($"Original value: {value}");
			WriteBinaryValue(" value:\t\t",  value);
			WriteBinaryValue("~value:\t\t", ~value);
			WriteBinaryValue("~value + 1:\t", ~value + 1);
			WriteBinaryValue("-value:\t\t", -value);
		}
	}
}