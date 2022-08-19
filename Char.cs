public struct Char : IComparable, IConvertible, IComparable<char>, IEquatable<char> // TypeDefIndex: 183
{	// Fields
	internal char m_value; // 0x0
	public const char MaxValue = '\xffff';
	public const char MinValue = '\x0';
	private static readonly byte[] categoryForLatin1; // 0x0
	internal const int UNICODE_PLANE00_END = 65535;
	internal const int UNICODE_PLANE01_START = 65536;
	internal const int UNICODE_PLANE16_END = 1114111;
	internal const int HIGH_SURROGATE_START = 55296;
	internal const int LOW_SURROGATE_END = 57343;

	// Methods

	// RVA: 0x158FC10 Offset: 0x158F010 VA: 0x18158FC10
	private static bool IsLatin1(char ch) { }

	// RVA: 0x158F830 Offset: 0x158EC30 VA: 0x18158F830
	private static bool IsAscii(char ch) { }

	// RVA: 0x158F590 Offset: 0x158E990 VA: 0x18158F590
	private static UnicodeCategory GetLatin1UnicodeCategory(char ch) { }

	// RVA: 0x1F34C0 Offset: 0x1F28C0 VA: 0x1801F34C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1F3420 Offset: 0x1F2820 VA: 0x1801F3420 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1F34B0 Offset: 0x1F28B0 VA: 0x1801F34B0 Slot: 23
	public bool Equals(char obj) { }

	// RVA: 0x1F3350 Offset: 0x1F2750 VA: 0x1801F3350 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x1F3340 Offset: 0x1F2740 VA: 0x1801F3340 Slot: 22
	public int CompareTo(char value) { }

	// RVA: 0x1F38D0 Offset: 0x1F2CD0 VA: 0x1801F38D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1F3930 Offset: 0x1F2D30 VA: 0x1801F3930 Slot: 20
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x15911D0 Offset: 0x15905D0 VA: 0x1815911D0
	public static string ToString(char c) { }

	// RVA: 0x1590A60 Offset: 0x158FE60 VA: 0x181590A60
	public static char Parse(string s) { }

	// RVA: 0x1591550 Offset: 0x1590950 VA: 0x181591550
	public static bool TryParse(string s, out char result) { }

	// RVA: 0x158FA50 Offset: 0x158EE50 VA: 0x18158FA50
	public static bool IsDigit(char c) { }

	// RVA: 0x158F290 Offset: 0x158E690 VA: 0x18158F290
	internal static bool CheckLetter(UnicodeCategory uc) { }

	// RVA: 0x158FE90 Offset: 0x158F290 VA: 0x18158FE90
	public static bool IsLetter(char c) { }

	// RVA: 0x15907E0 Offset: 0x158FBE0 VA: 0x1815907E0
	private static bool IsWhiteSpaceLatin1(char c) { }

	// RVA: 0x1590810 Offset: 0x158FC10 VA: 0x181590810
	public static bool IsWhiteSpace(char c) { }

	// RVA: 0x15906E0 Offset: 0x158FAE0 VA: 0x1815906E0
	public static bool IsUpper(char c) { }

	// RVA: 0x158FFD0 Offset: 0x158F3D0 VA: 0x18158FFD0
	public static bool IsLower(char c) { }

	// RVA: 0x158F2B0 Offset: 0x158E6B0 VA: 0x18158F2B0
	internal static bool CheckPunctuation(UnicodeCategory uc) { }

	// RVA: 0x15903B0 Offset: 0x158F7B0 VA: 0x1815903B0
	public static bool IsPunctuation(char c) { }

	// RVA: 0x158F280 Offset: 0x158E680 VA: 0x18158F280
	internal static bool CheckLetterOrDigit(UnicodeCategory uc) { }

	// RVA: 0x158FDB0 Offset: 0x158F1B0 VA: 0x18158FDB0
	public static bool IsLetterOrDigit(char c) { }

	// RVA: 0x15914B0 Offset: 0x15908B0 VA: 0x1815914B0
	public static char ToUpper(char c, CultureInfo culture) { }

	// RVA: 0x15913B0 Offset: 0x15907B0 VA: 0x1815913B0
	public static char ToUpper(char c) { }

	// RVA: 0x15912B0 Offset: 0x15906B0 VA: 0x1815912B0
	public static char ToUpperInvariant(char c) { }

	// RVA: 0x1591030 Offset: 0x1590430 VA: 0x181591030
	public static char ToLower(char c, CultureInfo culture) { }

	// RVA: 0x15910D0 Offset: 0x15904D0 VA: 0x1815910D0
	public static char ToLower(char c) { }

	// RVA: 0x1590F30 Offset: 0x1590330 VA: 0x181590F30
	public static char ToLowerInvariant(char c) { }

	// RVA: 0x1F34D0 Offset: 0x1F28D0 VA: 0x1801F34D0 Slot: 5
	public TypeCode GetTypeCode() { }

	// RVA: 0x1F34E0 Offset: 0x1F28E0 VA: 0x1801F34E0 Slot: 6
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x120F10 Offset: 0x120310 VA: 0x180120F10 Slot: 7
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x1F36B0 Offset: 0x1F2AB0 VA: 0x1801F36B0 Slot: 8
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x1F34F0 Offset: 0x1F28F0 VA: 0x1801F34F0 Slot: 9
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x1F3590 Offset: 0x1F2990 VA: 0x1801F3590 Slot: 10
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x1F37B0 Offset: 0x1F2BB0 VA: 0x1801F37B0 Slot: 11
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x1F35F0 Offset: 0x1F29F0 VA: 0x1801F35F0 Slot: 12
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x1F3810 Offset: 0x1F2C10 VA: 0x1801F3810 Slot: 13
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x1F3650 Offset: 0x1F2A50 VA: 0x1801F3650 Slot: 14
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x1F3870 Offset: 0x1F2C70 VA: 0x1801F3870 Slot: 15
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x1F3710 Offset: 0x1F2B10 VA: 0x1801F3710 Slot: 16
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x1F3580 Offset: 0x1F2980 VA: 0x1801F3580 Slot: 17
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x1F3560 Offset: 0x1F2960 VA: 0x1801F3560 Slot: 18
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x1F3550 Offset: 0x1F2950 VA: 0x1801F3550 Slot: 19
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x1F3720 Offset: 0x1F2B20 VA: 0x1801F3720 Slot: 21
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x158F840 Offset: 0x158EC40 VA: 0x18158F840
	public static bool IsControl(char c) { }

	// RVA: 0x158F900 Offset: 0x158ED00 VA: 0x18158F900
	public static bool IsControl(string s, int index) { }

	// RVA: 0x158FC20 Offset: 0x158F020 VA: 0x18158FC20
	public static bool IsLetterOrDigit(string s, int index) { }

	// RVA: 0x158F2A0 Offset: 0x158E6A0 VA: 0x18158F2A0
	internal static bool CheckNumber(UnicodeCategory uc) { }

	// RVA: 0x15900D0 Offset: 0x158F4D0 VA: 0x1815900D0
	public static bool IsNumber(char c) { }

	// RVA: 0x15901F0 Offset: 0x158F5F0 VA: 0x1815901F0
	public static bool IsNumber(string s, int index) { }

	// RVA: 0x158F2C0 Offset: 0x158E6C0 VA: 0x18158F2C0
	internal static bool CheckSeparator(UnicodeCategory uc) { }

	// RVA: 0x1590490 Offset: 0x158F890 VA: 0x181590490
	private static bool IsSeparatorLatin1(char c) { }

	// RVA: 0x15904B0 Offset: 0x158F8B0 VA: 0x1815904B0
	public static bool IsSeparator(char c) { }

	// RVA: 0x15906C0 Offset: 0x158FAC0 VA: 0x1815906C0
	public static bool IsSurrogate(char c) { }

	// RVA: 0x15905C0 Offset: 0x158F9C0 VA: 0x1815905C0
	public static bool IsSurrogate(string s, int index) { }

	// RVA: 0x15908E0 Offset: 0x158FCE0 VA: 0x1815908E0
	public static bool IsWhiteSpace(string s, int index) { }

	// RVA: 0x158F620 Offset: 0x158EA20 VA: 0x18158F620
	public static UnicodeCategory GetUnicodeCategory(char c) { }

	// RVA: 0x158F6D0 Offset: 0x158EAD0 VA: 0x18158F6D0
	public static UnicodeCategory GetUnicodeCategory(string s, int index) { }

	// RVA: 0x158FAF0 Offset: 0x158EEF0 VA: 0x18158FAF0
	public static bool IsHighSurrogate(char c) { }

	// RVA: 0x158FB10 Offset: 0x158EF10 VA: 0x18158FB10
	public static bool IsHighSurrogate(string s, int index) { }

	// RVA: 0x158FFB0 Offset: 0x158F3B0 VA: 0x18158FFB0
	public static bool IsLowSurrogate(char c) { }

	// RVA: 0x1590590 Offset: 0x158F990 VA: 0x181590590
	public static bool IsSurrogatePair(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x158F3B0 Offset: 0x158E7B0 VA: 0x18158F3B0
	public static int ConvertToUtf32(char highSurrogate, char lowSurrogate) { }

	// RVA: 0x1591580 Offset: 0x1590980 VA: 0x181591580
	private static void .cctor() { }

}

