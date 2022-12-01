public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 183
{
	internal char m_value;
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] categoryForLatin1;
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;


	private static bool IsLatin1(char ch) { }

	private static bool IsAscii(char ch) { }

	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(char obj) { }

	public int CompareTo(object value) { }

	public int CompareTo(char value) { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public static string ToString(char c) { }

	public static char Parse(string s) { }

	public static bool TryParse(string s, out char result) { }

	public static bool IsDigit(char c) { }

	internal static bool CheckLetter(UnicodeCategory uc) { }

	public static bool IsLetter(char c) { }

	private static bool IsWhiteSpaceLatin1(char c) { }

	public static bool IsWhiteSpace(char c) { }

	public static bool IsUpper(char c) { }

	public static bool IsLower(char c) { }

	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	public static bool IsPunctuation(char c) { }

	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	public static bool IsLetterOrDigit(char c) { }

	public static char ToUpper(char c, CultureInfo culture) { }

	public static char ToUpper(char c) { }

	public static char ToUpperInvariant(char c) { }

	public static char ToLower(char c, CultureInfo culture) { }

	public static char ToLower(char c) { }

	public static char ToLowerInvariant(char c) { }

	public TypeCode GetTypeCode() { }

	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	public static bool IsControl(char c) { }

	public static bool IsControl(string s, int index) { }

	public static bool IsLetterOrDigit(string s, int index) { }

	internal static bool CheckNumber(UnicodeCategory uc) { }

	public static bool IsNumber(char c) { }

	public static bool IsNumber(string s, int index) { }

	internal static bool CheckSeparator(UnicodeCategory uc) { }

	private static bool IsSeparatorLatin1(char c) { }

	public static bool IsSeparator(char c) { }

	public static bool IsSurrogate(char c) { }

	public static bool IsSurrogate(string s, int index) { }

	public static bool IsWhiteSpace(string s, int index) { }

	public static UnicodeCategory GetUnicodeCategory(char c) { }

	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	public static bool IsHighSurrogate(char c) { }

	public static bool IsHighSurrogate(string s, int index) { }

	public static bool IsLowSurrogate(char c) { }

	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	private static void .cctor() { }

}

