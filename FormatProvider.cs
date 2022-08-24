internal class FormatProvider // TypeDefIndex: 3970
{

	internal static string FormatBigInteger(int precision, int scale, bool sign, string format, NumberFormatInfo numberFormatInfo, char[] digits, int startIndex) { }

	internal static bool TryStringToBigInteger(ReadOnlySpan<char> s, NumberStyles styles, NumberFormatInfo numberFormatInfo, StringBuilder receiver, out int precision, out int scale, out bool sign) { }

}

private class FormatProvider.Number // TypeDefIndex: 3971
{
	private static string[] s_posCurrencyFormats; 
	private static string[] s_negCurrencyFormats; 
	private static string[] s_posPercentFormats; 
	private static string[] s_negPercentFormats; 
	private static string[] s_negNumberFormats; 
	private static string s_posNumberFormat; 


	private static bool IsWhite(char ch) { }

	private static char* MatchChars(char* p, string str) { }

	private static char* MatchChars(char* p, char* str) { }

	private static bool ParseNumber(ref char* str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	private static bool TrailingZeros(ReadOnlySpan<char> s, int index) { }

	internal static bool TryStringToNumber(ReadOnlySpan<char> str, NumberStyles options, ref FormatProvider.Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	internal static void Int32ToDecChars(char* buffer, ref int index, uint value, int digits) { }

	internal static char ParseFormatSpecifier(string format, out int digits) { }

	internal static string NumberToString(FormatProvider.Number.NumberBuffer number, char format, int nMaxDigits, NumberFormatInfo info, bool isDecimal) { }

	private static void FormatCurrency(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	private static int wcslen(char* s) { }

	private static void FormatFixed(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, int[] groupDigits, string sDecimal, string sGroup) { }

	private static void FormatNumber(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	private static void FormatScientific(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar) { }

	private static void FormatExponent(StringBuilder sb, NumberFormatInfo info, int value, char expChar, int minDigits, bool positiveSign) { }

	private static void FormatGeneral(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info, char expChar, bool bSuppressScientific) { }

	private static void FormatPercent(StringBuilder sb, FormatProvider.Number.NumberBuffer number, int nMinDigits, int nMaxDigits, NumberFormatInfo info) { }

	private static void RoundNumber(ref FormatProvider.Number.NumberBuffer number, int pos) { }

	private static int FindSection(string format, int section) { }

	internal static string NumberToStringFormat(FormatProvider.Number.NumberBuffer number, string format, NumberFormatInfo info) { }

	private static void .cctor() { }

}

internal struct FormatProvider.Number.NumberBuffer // TypeDefIndex: 3972
{
	public int precision; 
	public int scale; 
	public bool sign; 
	public char* overrideDigits; 

	public char* digits { get; }


	public char* get_digits() { }

}

