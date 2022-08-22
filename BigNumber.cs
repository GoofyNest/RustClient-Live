internal static class BigNumber // TypeDefIndex: 3966
{
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	internal static char ParseFormatSpecifier(string format, out int digits) { }

	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10


	public static BigNumber.BigNumberBuffer Create() { }

}

