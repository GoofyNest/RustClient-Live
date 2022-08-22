internal sealed class NumberFormatter // TypeDefIndex: 381
{	private static readonly ulong* MantissaBitsTable; // 0x0
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

	private CultureInfo CurrentCulture { set; }
	private int IntegerDigits { get; }
	private int DecimalDigits { get; }
	private bool IsFloatingSource { get; }
	private bool IsZero { get; }
	private bool IsZeroInteger { get; }


	private static void GetFormatterTables(out ulong* MantissaBitsTable, out int* TensExponentTable, out char* DigitLowerTable, out char* DigitUpperTable, out long* TenPowersList, out int* DecHexDigits) { }

	private static void .cctor() { }

	private static long GetTenPowerOf(int i) { }

	private void InitDecHexDigits(uint value) { }

	private void InitDecHexDigits(ulong value) { }

	private void InitDecHexDigits(uint hi, ulong lo) { }

	private static uint FastToDecHex(int val) { }

	private static uint ToDecHex(int val) { }

	private static int FastDecHexLen(int val) { }

	private static int DecHexLen(uint val) { }

	private int DecHexLen() { }

	private static int ScaleOrder(long hi) { }

	private int InitialFloatingPrecision() { }

	private static int ParsePrecision(string format) { }

	private void .ctor(Thread current) { }

	private void Init(string format) { }

	private void InitHex(ulong value) { }

	private void Init(string format, int value, int defPrecision) { }

	private void Init(string format, uint value, int defPrecision) { }

	private void Init(string format, long value) { }

	private void Init(string format, ulong value) { }

	private void Init(string format, double value, int defPrecision) { }

	private void Init(string format, Decimal value) { }

	private void ResetCharBuf(int size) { }

	private void Resize(int len) { }

	private void Append(char c) { }

	private void Append(char c, int cnt) { }

	private void Append(string s) { }

	private NumberFormatInfo GetNumberFormatInstance(IFormatProvider fp) { }

	private void set_CurrentCulture(CultureInfo value) { }

	private int get_IntegerDigits() { }

	private int get_DecimalDigits() { }

	private bool get_IsFloatingSource() { }

	private bool get_IsZero() { }

	private bool get_IsZeroInteger() { }

	private void RoundPos(int pos) { }

	private bool RoundDecimal(int decimals) { }

	private bool RoundBits(int shift) { }

	private void RemoveTrailingZeros() { }

	private void AddOneToDecHex() { }

	private static uint AddOneToDecHex(uint val) { }

	private int CountTrailingZeros() { }

	private static int CountTrailingZeros(uint val) { }

	private static NumberFormatter GetInstance(IFormatProvider fp) { }

	private void Release() { }

	public static string NumberToString(string format, uint value, IFormatProvider fp) { }

	public static string NumberToString(string format, int value, IFormatProvider fp) { }

	public static string NumberToString(string format, ulong value, IFormatProvider fp) { }

	public static string NumberToString(string format, long value, IFormatProvider fp) { }

	public static string NumberToString(string format, float value, IFormatProvider fp) { }

	public static string NumberToString(string format, double value, IFormatProvider fp) { }

	public static string NumberToString(string format, Decimal value, IFormatProvider fp) { }

	private string IntegerToString(string format, IFormatProvider fp) { }

	private string NumberToString(string format, NumberFormatInfo nfi) { }

	private string FormatCurrency(int precision, NumberFormatInfo nfi) { }

	private string FormatDecimal(int precision, NumberFormatInfo nfi) { }

	private string FormatHexadecimal(int precision) { }

	private string FormatFixedPoint(int precision, NumberFormatInfo nfi) { }

	private string FormatRoundtrip(double origval, NumberFormatInfo nfi) { }

	private string FormatRoundtrip(float origval, NumberFormatInfo nfi) { }

	private string FormatGeneral(int precision, NumberFormatInfo nfi) { }

	private string FormatNumber(int precision, NumberFormatInfo nfi) { }

	private string FormatPercent(int precision, NumberFormatInfo nfi) { }

	private string FormatExponential(int precision, NumberFormatInfo nfi) { }

	private string FormatExponential(int precision, NumberFormatInfo nfi, int expDigits) { }

	private string FormatCustom(string format, NumberFormatInfo nfi) { }

	private static void ZeroTrimEnd(StringBuilder sb, bool canEmpty) { }

	private static bool IsZeroOnly(StringBuilder sb) { }

	private static void AppendNonNegativeNumber(StringBuilder sb, int v) { }

	private void AppendIntegerString(int minLength, StringBuilder sb) { }

	private void AppendIntegerString(int minLength) { }

	private void AppendDecimalString(int precision, StringBuilder sb) { }

	private void AppendDecimalString(int precision) { }

	private void AppendIntegerStringWithGroupSeparator(int[] groups, string groupSeparator) { }

	private void AppendExponent(NumberFormatInfo nfi, int exponent, int minDigits) { }

	private void AppendOneDigit(int start) { }

	private void AppendDigits(int start, int end) { }

	private void AppendDigits(int start, int end, StringBuilder sb) { }

	private void Multiply10(int count) { }

	private void Divide10(int count) { }

	private NumberFormatter GetClone() { }

}

private class NumberFormatter.CustomInfo // TypeDefIndex: 382
{	public bool UseGroup; // 0x10
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


	public static void GetActiveSection(string format, ref bool positive, bool zero, ref int offset, ref int length) { }

	public static NumberFormatter.CustomInfo Parse(string format, int offset, int length, NumberFormatInfo nfi) { }

	public string Format(string format, int offset, int length, NumberFormatInfo nfi, bool positive, StringBuilder sb_int, StringBuilder sb_dec, StringBuilder sb_exp) { }

	public void .ctor() { }

}

