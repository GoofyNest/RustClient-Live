internal class Number // TypeDefIndex: 278
{

	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	private static bool IsWhite(char ch) { }

	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	private static char* MatchChars(char* p, string str) { }

	private static char* MatchChars(char* p, char* str) { }

	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	private static bool TrailingZeros(string s, int index) { }

	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute]
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

}

internal struct Number.NumberBuffer // TypeDefIndex: 279
{
	public static readonly int NumberBufferBytes;
	private byte* baseAddress;
	public char* digits;
	public int precision;
	public int scale;
	public bool sign;


	public void .ctor(byte* stackBuffer) { }

	public byte* PackForNative() { }

	private static void .cctor() { }

}

