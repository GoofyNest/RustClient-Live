internal class FormatProvider // TypeDefIndex: 3970
{	// Methods

	// RVA: 0x222E380 Offset: 0x222D780 VA: 0x18222E380
	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	// RVA: 0x222E5D0 Offset: 0x222D9D0 VA: 0x18222E5D0
	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

private class FormatProvider.Number // TypeDefIndex: 3971
{	// Fields
	private static string[] s_posCurrencyFormats; // 0x0
	private static string[] s_negCurrencyFormats; // 0x8
	private static string[] s_posPercentFormats; // 0x10
	private static string[] s_negPercentFormats; // 0x18
	private static string[] s_negNumberFormats; // 0x20
	private static string s_posNumberFormat; // 0x28

	// Methods

	// RVA: 0x167B100 Offset: 0x167A500 VA: 0x18167B100
	private static bool IsWhite(char ch) { }

	// RVA: 0x222F870 Offset: 0x222EC70 VA: 0x18222F870
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x222F920 Offset: 0x222ED20 VA: 0x18222F920
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x2231060 Offset: 0x2230460 VA: 0x182231060
	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x2231C80 Offset: 0x2231080 VA: 0x182231C80
	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	// RVA: 0x2231D00 Offset: 0x2231100 VA: 0x182231D00
	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x222F810 Offset: 0x222EC10 VA: 0x18222F810
	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	// RVA: 0x2230F70 Offset: 0x2230370 VA: 0x182230F70
	internal static char ParseFormatSpecifier(string format, out int digits) { }

	// RVA: 0x22305D0 Offset: 0x222F9D0 VA: 0x1822305D0
	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	// RVA: 0x222E7C0 Offset: 0x222DBC0 VA: 0x18222E7C0
	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x22330B0 Offset: 0x22324B0 VA: 0x1822330B0
	private static int wcslen(char* s) { }

	// RVA: 0x222EBD0 Offset: 0x222DFD0 VA: 0x18222EBD0
	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	// RVA: 0x222F1B0 Offset: 0x222E5B0 VA: 0x18222F1B0
	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x222F6B0 Offset: 0x222EAB0 VA: 0x18222F6B0
	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	// RVA: 0x222EA60 Offset: 0x222DE60 VA: 0x18222EA60
	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	// RVA: 0x222F000 Offset: 0x222E400 VA: 0x18222F000
	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	// RVA: 0x222F400 Offset: 0x222E800 VA: 0x18222F400
	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	// RVA: 0x2231BA0 Offset: 0x2230FA0 VA: 0x182231BA0
	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	// RVA: 0x222E6F0 Offset: 0x222DAF0 VA: 0x18222E6F0
	private static int FindSection(string format, int section) { }

	// RVA: 0x222F970 Offset: 0x222ED70 VA: 0x18222F970
	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	// RVA: 0x2231F30 Offset: 0x2231330 VA: 0x182231F30
	private static void .cctor() { }

}

internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 3972
{	// Fields
	public int precision; // 0x0
	public int scale; // 0x4
	public bool sign; // 0x8
	public char* overrideDigits; // 0x10

	// Properties
	public char* digits { get; }

	// Methods

	// RVA: 0xF3DD0 Offset: 0xF31D0 VA: 0x1800F3DD0
	public char* get_digits() { }

}

