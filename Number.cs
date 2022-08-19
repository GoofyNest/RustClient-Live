internal class Number // TypeDefIndex: 278
{	// Methods

	// RVA: 0x167B1D0 Offset: 0x167A5D0 VA: 0x18167B1D0
	public static bool NumberBufferToDecimal(byte* number, ref Decimal value) { }

	// RVA: 0x167B1E0 Offset: 0x167A5E0 VA: 0x18167B1E0
	internal static bool NumberBufferToDouble(byte* number, ref double value) { }

	// RVA: 0x167A6F0 Offset: 0x1679AF0 VA: 0x18167A6F0
	public static string FormatDecimal(Decimal value, string format, NumberFormatInfo info) { }

	// RVA: 0x167A810 Offset: 0x1679C10 VA: 0x18167A810
	public static string FormatDouble(double value, string format, NumberFormatInfo info) { }

	// RVA: 0x167A890 Offset: 0x1679C90 VA: 0x18167A890
	public static string FormatInt32(int value, string format, NumberFormatInfo info) { }

	// RVA: 0x167ABF0 Offset: 0x1679FF0 VA: 0x18167ABF0
	public static string FormatUInt32(uint value, string format, NumberFormatInfo info) { }

	// RVA: 0x167AA00 Offset: 0x1679E00 VA: 0x18167AA00
	public static string FormatInt64(long value, string format, NumberFormatInfo info) { }

	// RVA: 0x167AD50 Offset: 0x167A150 VA: 0x18167AD50
	public static string FormatUInt64(ulong value, string format, NumberFormatInfo info) { }

	// RVA: 0x167AB70 Offset: 0x1679F70 VA: 0x18167AB70
	public static string FormatSingle(float value, string format, NumberFormatInfo info) { }

	// RVA: 0x167AEB0 Offset: 0x167A2B0 VA: 0x18167AEB0
	private static bool HexNumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x167AF30 Offset: 0x167A330 VA: 0x18167AF30
	private static bool HexNumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x167AFF0 Offset: 0x167A3F0 VA: 0x18167AFF0
	private static bool HexNumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x167B070 Offset: 0x167A470 VA: 0x18167B070
	private static bool HexNumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x167B100 Offset: 0x167A500 VA: 0x18167B100
	private static bool IsWhite(char ch) { }

	// RVA: 0x167B1F0 Offset: 0x167A5F0 VA: 0x18167B1F0
	private static bool NumberToInt32(ref Number.NumberBuffer number, ref int value) { }

	// RVA: 0x167B250 Offset: 0x167A650 VA: 0x18167B250
	private static bool NumberToInt64(ref Number.NumberBuffer number, ref long value) { }

	// RVA: 0x167B2D0 Offset: 0x167A6D0 VA: 0x18167B2D0
	private static bool NumberToUInt32(ref Number.NumberBuffer number, ref uint value) { }

	// RVA: 0x167B330 Offset: 0x167A730 VA: 0x18167B330
	private static bool NumberToUInt64(ref Number.NumberBuffer number, ref ulong value) { }

	// RVA: 0x167B160 Offset: 0x167A560 VA: 0x18167B160
	private static char* MatchChars(char* p, string str) { }

	// RVA: 0x167B120 Offset: 0x167A520 VA: 0x18167B120
	private static char* MatchChars(char* p, char* str) { }

	// RVA: 0x167B3A0 Offset: 0x167A7A0 VA: 0x18167B3A0
	internal static Decimal ParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167B510 Offset: 0x167A910 VA: 0x18167B510
	internal static double ParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167B7C0 Offset: 0x167ABC0 VA: 0x18167B7C0
	internal static int ParseInt32(string s, NumberStyles style, NumberFormatInfo info) { }

	// RVA: 0x167BA10 Offset: 0x167AE10 VA: 0x18167BA10
	internal static long ParseInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167BC80 Offset: 0x167B080 VA: 0x18167BC80
	private static bool ParseNumber(ref char* str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

	// RVA: 0x167C770 Offset: 0x167BB70 VA: 0x18167C770
	internal static float ParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167CA90 Offset: 0x167BE90 VA: 0x18167CA90
	internal static uint ParseUInt32(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167CCD0 Offset: 0x167C0D0 VA: 0x18167CCD0
	internal static ulong ParseUInt64(string value, NumberStyles options, NumberFormatInfo numfmt) { }

	// RVA: 0x167CF30 Offset: 0x167C330 VA: 0x18167CF30
	private static void StringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo info, bool parseDecimal) { }

	// RVA: 0x167D070 Offset: 0x167C470 VA: 0x18167D070
	private static bool TrailingZeros(string s, int index) { }

	// RVA: 0x167D0D0 Offset: 0x167C4D0 VA: 0x18167D0D0
	internal static bool TryParseDecimal(string value, NumberStyles options, NumberFormatInfo numfmt, out Decimal result) { }

	// RVA: 0x167D250 Offset: 0x167C650 VA: 0x18167D250
	internal static bool TryParseDouble(string value, NumberStyles options, NumberFormatInfo numfmt, out double result) { }

	// RVA: 0x167D3D0 Offset: 0x167C7D0 VA: 0x18167D3D0
	internal static bool TryParseInt32(string s, NumberStyles style, NumberFormatInfo info, out int result) { }

	// RVA: 0x167D610 Offset: 0x167CA10 VA: 0x18167D610
	internal static bool TryParseInt64(string s, NumberStyles style, NumberFormatInfo info, out long result) { }

	// RVA: 0x167D7E0 Offset: 0x167CBE0 VA: 0x18167D7E0
	internal static bool TryParseSingle(string value, NumberStyles options, NumberFormatInfo numfmt, out float result) { }

	// RVA: 0x167D990 Offset: 0x167CD90 VA: 0x18167D990
	internal static bool TryParseUInt32(string s, NumberStyles style, NumberFormatInfo info, out uint result) { }

	// RVA: 0x167DBD0 Offset: 0x167CFD0 VA: 0x18167DBD0
	internal static bool TryParseUInt64(string s, NumberStyles style, NumberFormatInfo info, out ulong result) { }

	// RVA: 0x167DEF0 Offset: 0x167D2F0 VA: 0x18167DEF0
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, NumberFormatInfo numfmt, bool parseDecimal) { }

	[FriendAccessAllowedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x167DE20 Offset: 0x167D220 VA: 0x18167DE20
	internal static bool TryStringToNumber(string str, NumberStyles options, ref Number.NumberBuffer number, StringBuilder sb, NumberFormatInfo numfmt, bool parseDecimal) { }

}

internal struct Number.NumberBuffer // TypeDefIndex: 279
{	// Fields
	public static readonly int NumberBufferBytes; // 0x0
	private byte* baseAddress; // 0x0
	public char* digits; // 0x8
	public int precision; // 0x10
	public int scale; // 0x14
	public bool sign; // 0x18

	// Methods

	// RVA: 0x1FBF90 Offset: 0x1FB390 VA: 0x1801FBF90
	public void .ctor(byte* stackBuffer) { }

	// RVA: 0x1FBF70 Offset: 0x1FB370 VA: 0x1801FBF70
	public byte* PackForNative() { }

	// RVA: 0x1674A90 Offset: 0x1673E90 VA: 0x181674A90
	private static void .cctor() { }

}

