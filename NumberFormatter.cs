internal sealed class NumberFormatter // TypeDefIndex: 381
{	// Fields
	private static readonly ulong* MantissaBitsTable; // 0x0
	private static readonly int* TensExponentTable; // 0x8
	private static readonly char* DigitLowerTable; // 0x10
	private static readonly char* DigitUpperTable; // 0x18
	private static readonly long* TenPowersList; // 0x20
	private static readonly int* DecHexDigits; // 0x28
	private NumberFormatInfo _nfi; // 0x10
	private char[] _cbuf; // 0x18
	private bool _NaN; // 0x20
	private bool _infinity; // 0x21
	private bool _isCustomFormat; // 0x22
	private bool _specifierIsUpper; // 0x23
	private bool _positive; // 0x24
	private char _specifier; // 0x26
	private int _precision; // 0x28
	private int _defPrecision; // 0x2C
	private int _digitsLen; // 0x30
	private int _offset; // 0x34
	private int _decPointPos; // 0x38
	private uint _val1; // 0x3C
	private uint _val2; // 0x40
	private uint _val3; // 0x44
	private uint _val4; // 0x48
	private int _ind; // 0x4C
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static NumberFormatter threadNumberFormatter; // 0x80000000
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static NumberFormatter userFormatProvider; // 0x80000008

	// Properties
	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }

	// Methods

	// RVA: 0x1677D70 Offset: 0x1677170 VA: 0x181677D70
	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	// RVA: 0x167A510 Offset: 0x1679910 VA: 0x18167A510
	private static void .cctor() { }

	// RVA: 0x1677FB0 Offset: 0x16773B0 VA: 0x181677FB0
	private static long GetTenPowerOf(int i) { }

	// RVA: 0x1678360 Offset: 0x1677760 VA: 0x181678360
	private void InitDecHexDigits(uint value) { }

	// RVA: 0x1678220 Offset: 0x1677620 VA: 0x181678220
	private void InitDecHexDigits(ulong value) { }

	// RVA: 0x1678020 Offset: 0x1677420 VA: 0x181678020
	private void InitDecHexDigits(uint hi, ulong lo) { }

	// RVA: 0x16761E0 Offset: 0x16755E0 VA: 0x1816761E0
	private static uint FastToDecHex(int val) { }

	// RVA: 0x167A3C0 Offset: 0x16797C0 VA: 0x18167A3C0
	private static uint ToDecHex(int val) { }

	// RVA: 0x16761B0 Offset: 0x16755B0 VA: 0x1816761B0
	private static int FastDecHexLen(int val) { }

	// RVA: 0x16760E0 Offset: 0x16754E0 VA: 0x1816760E0
	private static int DecHexLen(uint val) { }

	// RVA: 0x1675FB0 Offset: 0x16753B0 VA: 0x181675FB0
	private int DecHexLen() { }

	// RVA: 0x167A340 Offset: 0x1679740 VA: 0x18167A340
	private static int ScaleOrder(long hi) { }

	// RVA: 0x1678ED0 Offset: 0x16782D0 VA: 0x181678ED0
	private int InitialFloatingPrecision() { }

	// RVA: 0x1679D90 Offset: 0x1679190 VA: 0x181679D90
	private static int ParsePrecision(string format) { }

	// RVA: 0x167A570 Offset: 0x1679970 VA: 0x18167A570
	private void .ctor(Thread current) { }

	// RVA: 0x1678BE0 Offset: 0x1677FE0 VA: 0x181678BE0
	private void Init(string format) { }

	// RVA: 0x16784B0 Offset: 0x16778B0 VA: 0x1816784B0
	private void InitHex(ulong value) { }

	// RVA: 0x1678590 Offset: 0x1677990 VA: 0x181678590
	private void Init(string format, int value, int defPrecision) { }

	// RVA: 0x1678640 Offset: 0x1677A40 VA: 0x181678640
	private void Init(string format, uint value, int defPrecision) { }

	// RVA: 0x16786E0 Offset: 0x1677AE0 VA: 0x1816786E0
	private void Init(string format, long value) { }

	// RVA: 0x1678500 Offset: 0x1677900 VA: 0x181678500
	private void Init(string format, ulong value) { }

	// RVA: 0x1678780 Offset: 0x1677B80 VA: 0x181678780
	private void Init(string format, double value, int defPrecision) { }

	// RVA: 0x1678D20 Offset: 0x1678120 VA: 0x181678D20
	private void Init(string format, Decimal value) { }

	// RVA: 0x1679EE0 Offset: 0x16792E0 VA: 0x181679EE0
	private void ResetCharBuf(int size) { }

	// RVA: 0x1679F50 Offset: 0x1679350 VA: 0x181679F50
	private void Resize(int len) { }

	// RVA: 0x1675B80 Offset: 0x1674F80 VA: 0x181675B80
	private void Append(char c) { }

	// RVA: 0x1675AA0 Offset: 0x1674EA0 VA: 0x181675AA0
	private void Append(char c, int cnt) { }

	// RVA: 0x1675C30 Offset: 0x1675030 VA: 0x181675C30
	private void Append(string s) { }

	// RVA: 0x1677F90 Offset: 0x1677390 VA: 0x181677F90
	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	// RVA: 0x167A6A0 Offset: 0x1679AA0 VA: 0x18167A6A0
	private void set_CurrentCulture(CultureInfo value) { }

	// RVA: 0x167A650 Offset: 0x1679A50 VA: 0x18167A650
	private int get_IntegerDigits() { }

	// RVA: 0x167A640 Offset: 0x1679A40 VA: 0x18167A640
	private int get_DecimalDigits() { }

	// RVA: 0x167A660 Offset: 0x1679A60 VA: 0x18167A660
	private bool get_IsFloatingSource() { }

	// RVA: 0x5F7B70 Offset: 0x5F6F70 VA: 0x1805F7B70
	private bool get_IsZero() { }

	// RVA: 0x167A680 Offset: 0x1679A80 VA: 0x18167A680
	private bool get_IsZeroInteger() { }

	// RVA: 0x167A330 Offset: 0x1679730 VA: 0x18167A330
	private void RoundPos(int pos) { }

	// RVA: 0x167A310 Offset: 0x1679710 VA: 0x18167A310
	private bool RoundDecimal(int decimals) { }

	// RVA: 0x1679FA0 Offset: 0x16793A0 VA: 0x181679FA0
	private bool RoundBits(int shift) { }

	// RVA: 0x1679EB0 Offset: 0x16792B0 VA: 0x181679EB0
	private void RemoveTrailingZeros() { }

	// RVA: 0x1674B50 Offset: 0x1673F50 VA: 0x181674B50
	private void AddOneToDecHex() { }

	// RVA: 0x1674AD0 Offset: 0x1673ED0 VA: 0x181674AD0
	private static uint AddOneToDecHex(uint val) { }

	// RVA: 0x1675D70 Offset: 0x1675170 VA: 0x181675D70
	private int CountTrailingZeros() { }

	// RVA: 0x1675D20 Offset: 0x1675120 VA: 0x181675D20
	private static int CountTrailingZeros(uint val) { }

	// RVA: 0x1677D80 Offset: 0x1677180 VA: 0x181677D80
	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	// RVA: 0x1679E10 Offset: 0x1679210 VA: 0x181679E10
	private void Release() { }

	// RVA: 0x1679A10 Offset: 0x1678E10 VA: 0x181679A10
	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	// RVA: 0x1679B30 Offset: 0x1678F30 VA: 0x181679B30
	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	// RVA: 0x1679810 Offset: 0x1678C10 VA: 0x181679810
	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	// RVA: 0x1679C60 Offset: 0x1679060 VA: 0x181679C60
	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	// RVA: 0x1679280 Offset: 0x1678680 VA: 0x181679280
	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	// RVA: 0x1679450 Offset: 0x1678850 VA: 0x181679450
	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	// RVA: 0x1679930 Offset: 0x1678D30 VA: 0x181679930
	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	// RVA: 0x1678FA0 Offset: 0x16783A0 VA: 0x181678FA0
	private string IntegerToString(string format, IFormatProvider fp) { }

	// RVA: 0x1679670 Offset: 0x1678A70 VA: 0x181679670
	private string NumberToString(string format, NumberFormatInfo nfi) { }

	// RVA: 0x16762B0 Offset: 0x16756B0 VA: 0x1816762B0
	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1676E60 Offset: 0x1676260 VA: 0x181676E60
	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1677590 Offset: 0x1676990 VA: 0x181677590
	private string FormatHexadecimal(int precision) { }

	// RVA: 0x1677290 Offset: 0x1676690 VA: 0x181677290
	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1677B10 Offset: 0x1676F10 VA: 0x181677B10
	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	// RVA: 0x1677C40 Offset: 0x1677040 VA: 0x181677C40
	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	// RVA: 0x1677420 Offset: 0x1676820 VA: 0x181677420
	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1677740 Offset: 0x1676B40 VA: 0x181677740
	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1677930 Offset: 0x1676D30 VA: 0x181677930
	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1677230 Offset: 0x1676630 VA: 0x181677230
	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	// RVA: 0x1676F20 Offset: 0x1676320 VA: 0x181676F20
	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	// RVA: 0x1676680 Offset: 0x1675A80 VA: 0x181676680
	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	// RVA: 0x167A470 Offset: 0x1679870 VA: 0x18167A470
	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	// RVA: 0x16791A0 Offset: 0x16785A0 VA: 0x1816791A0
	private static bool IsZeroOnly(StringBuilder sb) { }

	// RVA: 0x16757F0 Offset: 0x1674BF0 VA: 0x1816757F0
	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	// RVA: 0x1675700 Offset: 0x1674B00 VA: 0x181675700
	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	// RVA: 0x1675790 Offset: 0x1674B90 VA: 0x181675790
	private void AppendIntegerString(int minLength) { }

	// RVA: 0x1674C80 Offset: 0x1674080 VA: 0x181674C80
	private void AppendDecimalString(int precision, StringBuilder sb) { }

	// RVA: 0x1674CB0 Offset: 0x16740B0 VA: 0x181674CB0
	private void AppendDecimalString(int precision) { }

	// RVA: 0x16753B0 Offset: 0x16747B0 VA: 0x1816753B0
	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	// RVA: 0x1675250 Offset: 0x1674650 VA: 0x181675250
	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	// RVA: 0x16759B0 Offset: 0x1674DB0 VA: 0x1816759B0
	private void AppendOneDigit(int start) { }

	// RVA: 0x1674F10 Offset: 0x1674310 VA: 0x181674F10
	private void AppendDigits(int start, int end) { }

	// RVA: 0x1674CD0 Offset: 0x16740D0 VA: 0x181674CD0
	private void AppendDigits(int start, int end, StringBuilder sb) { }

	// RVA: 0x1679270 Offset: 0x1678670 VA: 0x181679270
	private void Multiply10(int count) { }

	// RVA: 0x16761A0 Offset: 0x16755A0 VA: 0x1816761A0
	private void Divide10(int count) { }

	// RVA: 0x1677D10 Offset: 0x1677110 VA: 0x181677D10
	private NumberFormatter GetClone() { }

}

private class NumberFormatter.CustomInfo // TypeDefIndex: 382
{	// Fields
	public bool UseGroup; // 0x10
	public int DecimalDigits; // 0x14
	public int DecimalPointPos; // 0x18
	public int DecimalTailSharpDigits; // 0x1C
	public int IntegerDigits; // 0x20
	public int IntegerHeadSharpDigits; // 0x24
	public int IntegerHeadPos; // 0x28
	public bool UseExponent; // 0x2C
	public int ExponentDigits; // 0x30
	public int ExponentTailSharpDigits; // 0x34
	public bool ExponentNegativeSignOnly; // 0x38
	public int DividePlaces; // 0x3C
	public int Percents; // 0x40
	public int Permilles; // 0x44

	// Methods

	// RVA: 0x166C3E0 Offset: 0x166B7E0 VA: 0x18166C3E0
	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	// RVA: 0x166C7F0 Offset: 0x166BBF0 VA: 0x18166C7F0
	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	// RVA: 0x166BC30 Offset: 0x166B030 VA: 0x18166BC30
	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	// RVA: 0x166CB60 Offset: 0x166BF60 VA: 0x18166CB60
	public void .ctor() { }

}

