internal static class BigNumber // TypeDefIndex: 3966
{	// Methods

	// RVA: 0x222E230 Offset: 0x222D630 VA: 0x18222E230
	internal static bool TryValidateParseStyleInteger(NumberStyles style, out ArgumentException e) { }

	// RVA: 0x222DFE0 Offset: 0x222D3E0 VA: 0x18222DFE0
	internal static bool TryParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info, out BigInteger result) { }

	// RVA: 0x222D9F0 Offset: 0x222CDF0 VA: 0x18222D9F0
	internal static BigInteger ParseBigInteger(string value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x222C6E0 Offset: 0x222BAE0 VA: 0x18222C6E0
	private static ReadOnlySpan<char> AsReadOnlySpan(string s) { }

	// RVA: 0x222DD10 Offset: 0x222D110 VA: 0x18222DD10
	internal static BigInteger ParseBigInteger(ReadOnlySpan<char> value, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x222D410 Offset: 0x222C810 VA: 0x18222D410
	private static bool HexNumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x222D6A0 Offset: 0x222CAA0 VA: 0x18222D6A0
	private static bool NumberToBigInteger(ref BigNumber.BigNumberBuffer number, ref BigInteger value) { }

	// RVA: 0x222DE80 Offset: 0x222D280 VA: 0x18222DE80
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x222C850 Offset: 0x222BC50 VA: 0x18222C850
	private static string FormatBigIntegerToHexString(BigInteger value, char format, int digits, NumberFormatInfo info) { }

	// RVA: 0x222CB40 Offset: 0x222BF40 VA: 0x18222CB40
	internal static string FormatBigInteger(BigInteger value, string format, NumberFormatInfo info) { }

}

private struct BigNumber.BigNumberBuffer // TypeDefIndex: 3967
{	// Fields
	public StringBuilder digits; // 0x0
	public int precision; // 0x8
	public int scale; // 0xC
	public bool sign; // 0x10

	// Methods

	// RVA: 0x222C670 Offset: 0x222BA70 VA: 0x18222C670
	public static BigNumber.BigNumberBuffer Create() { }

}

