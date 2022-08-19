public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 301
{	// Fields
	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	// Properties
	public char Chars { get; }
	public int Length { get; }

	// Methods

	// RVA: 0x18B22E0 Offset: 0x18B16E0 VA: 0x1818B22E0
	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B2680 Offset: 0x18B1A80 VA: 0x1818B2680
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: -1 Offset: -1
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83DC0 Offset: 0xE831C0 VA: 0x180E83DC0
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B2030 Offset: 0x18B1430 VA: 0x1818B2030
	public static string Join(string separator, IEnumerable<string> values) { }

	// RVA: 0x18B2370 Offset: 0x18B1770 VA: 0x1818B2370
	public static string Join(string separator, string[] value, int startIndex, int count) { }

	// RVA: 0x18ABDF0 Offset: 0x18AB1F0 VA: 0x1818ABDF0
	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x18AF310 Offset: 0x18AE710 VA: 0x1818AF310
	private static bool EqualsHelper(string strA, string strB) { }

	// RVA: 0x18ABC40 Offset: 0x18AB040 VA: 0x1818ABC40
	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x18AF730 Offset: 0x18AEB30 VA: 0x1818AF730 Slot: 0
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x18AF8F0 Offset: 0x18AECF0 VA: 0x1818AF8F0 Slot: 26
	public bool Equals(string value) { }

	// RVA: 0x18AF990 Offset: 0x18AED90 VA: 0x1818AF990
	public bool Equals(string value, StringComparison comparisonType) { }

	// RVA: 0x18AF8C0 Offset: 0x18AECC0 VA: 0x1818AF8C0
	public static bool Equals(string a, string b) { }

	// RVA: 0x18AF420 Offset: 0x18AE820 VA: 0x1818AF420
	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	// RVA: 0x18AF8C0 Offset: 0x18AECC0 VA: 0x1818AF8C0
	public static bool op_Equality(string a, string b) { }

	// RVA: 0x18B6C10 Offset: 0x18B6010 VA: 0x1818B6C10
	public static bool op_Inequality(string a, string b) { }

	// RVA: 0x18B68E0 Offset: 0x18B5CE0 VA: 0x1818B68E0
	public char get_Chars(int index) { }

	// RVA: 0x18AE050 Offset: 0x18AD450 VA: 0x1818AE050
	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	// RVA: 0x18B58C0 Offset: 0x18B4CC0 VA: 0x1818B58C0
	public char[] ToCharArray() { }

	// RVA: 0x100AB40 Offset: 0x1009F40 VA: 0x18100AB40
	public static bool IsNullOrEmpty(string value) { }

	// RVA: 0x18B1F30 Offset: 0x18B1330 VA: 0x1818B1F30
	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x18B07E0 Offset: 0x18AFBE0 VA: 0x1818B07E0 Slot: 2
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	// RVA: 0x18B07E0 Offset: 0x18AFBE0 VA: 0x1818B07E0
	internal int GetLegacyNonRandomizedHashCode() { }

	// RVA: 0x18B48E0 Offset: 0x18B3CE0 VA: 0x1818B48E0
	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B4900 Offset: 0x18B3D00 VA: 0x1818B4900
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B4690 Offset: 0x18B3A90 VA: 0x1818B4690
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B48C0 Offset: 0x18B3CC0 VA: 0x1818B48C0
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B4920 Offset: 0x18B3D20 VA: 0x1818B4920
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	// RVA: 0x18B1890 Offset: 0x18B0C90 VA: 0x1818B1890
	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B1B40 Offset: 0x18B0F40 VA: 0x1818B1B40
	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	// RVA: 0x18B3250 Offset: 0x18B2650 VA: 0x1818B3250
	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	// RVA: 0x18B33F0 Offset: 0x18B27F0 VA: 0x1818B33F0
	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	// RVA: 0x18B4F70 Offset: 0x18B4370 VA: 0x1818B4F70
	public string Substring(int startIndex) { }

	// RVA: 0x18B4F80 Offset: 0x18B4380 VA: 0x1818B4F80
	public string Substring(int startIndex, int length) { }

	// RVA: 0x18B1E90 Offset: 0x18B1290 VA: 0x1818B1E90
	private string InternalSubString(int startIndex, int length) { }

	// RVA: 0x18B65B0 Offset: 0x18B59B0 VA: 0x1818B65B0
	public string Trim(char[] trimChars) { }

	// RVA: 0x18B6480 Offset: 0x18B5880 VA: 0x1818B6480
	public string TrimStart(char[] trimChars) { }

	// RVA: 0x18B5E40 Offset: 0x18B5240 VA: 0x1818B5E40
	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	// RVA: 0x18AE300 Offset: 0x18AD700 VA: 0x1818AE300
	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	// RVA: 0x18B35B0 Offset: 0x18B29B0 VA: 0x1818B35B0
	public string Normalize(NormalizationForm normalizationForm) { }

	// RVA: 0x18AFC90 Offset: 0x18AF090 VA: 0x1818AFC90
	internal static string FastAllocateString(int length) { }

	// RVA: 0x18AFCA0 Offset: 0x18AF0A0 VA: 0x1818AFCA0
	private static void FillStringChecked(string dest, int destPos, string src) { }

	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(char[] value, int startIndex, int length) { }

	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(char[] value) { }

	// RVA: 0x18B6CB0 Offset: 0x18B60B0 VA: 0x1818B6CB0
	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	// RVA: 0x18AEBA0 Offset: 0x18ADFA0 VA: 0x1818AEBA0
	private string CtorCharArray(char[] value) { }

	// RVA: 0x18AE9C0 Offset: 0x18ADDC0 VA: 0x1818AE9C0
	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	// RVA: 0x18B6C50 Offset: 0x18B6050 VA: 0x1818B6C50
	private static int wcslen(char* ptr) { }

	// RVA: 0x18AEE40 Offset: 0x18AE240 VA: 0x1818AEE40
	private string CtorCharPtr(char* ptr) { }

	// RVA: 0x18AEC40 Offset: 0x18AE040 VA: 0x1818AEC40
	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	// RVA: 0x18B67C0 Offset: 0x18B5BC0 VA: 0x1818B67C0
	public void .ctor(char c, int count) { }

	// RVA: 0x18ACDB0 Offset: 0x18AC1B0 VA: 0x1818ACDB0
	public static int Compare(string strA, string strB, bool ignoreCase) { }

	// RVA: 0x18AC920 Offset: 0x18ABD20 VA: 0x1818AC920
	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	// RVA: 0x18ACFC0 Offset: 0x18AC3C0 VA: 0x1818ACFC0
	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18ACEB0 Offset: 0x18AC2B0 VA: 0x1818ACEB0
	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18ACC50 Offset: 0x18AC050 VA: 0x1818ACC50
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	// RVA: 0x18AC800 Offset: 0x18ABC00 VA: 0x1818AC800
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	// RVA: 0x18AC330 Offset: 0x18AB730 VA: 0x1818AC330
	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	// RVA: 0x18AC1B0 Offset: 0x18AB5B0 VA: 0x1818AC1B0 Slot: 4
	public int CompareTo(object value) { }

	// RVA: 0x18AC0F0 Offset: 0x18AB4F0 VA: 0x1818AC0F0 Slot: 24
	public int CompareTo(string strB) { }

	// RVA: 0x18AC070 Offset: 0x18AB470 VA: 0x1818AC070
	public static int CompareOrdinal(string strA, string strB) { }

	// RVA: 0x18AC0B0 Offset: 0x18AB4B0 VA: 0x1818AC0B0
	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	// RVA: 0x18ADEA0 Offset: 0x18AD2A0 VA: 0x1818ADEA0
	public bool Contains(string value) { }

	// RVA: 0x18AF300 Offset: 0x18AE700 VA: 0x1818AF300
	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18AF000 Offset: 0x18AE400 VA: 0x1818AF000
	public bool EndsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18AEFD0 Offset: 0x18AE3D0 VA: 0x1818AEFD0
	internal bool EndsWith(char value) { }

	// RVA: 0x18B0F50 Offset: 0x18B0350 VA: 0x1818B0F50
	public int IndexOf(char value) { }

	// RVA: 0x18B0FA0 Offset: 0x18B03A0 VA: 0x1818B0FA0
	public int IndexOf(char value, int startIndex) { }

	// RVA: 0x18B0970 Offset: 0x18AFD70 VA: 0x1818B0970
	public int IndexOfAny(char[] anyOf) { }

	// RVA: 0x18B0990 Offset: 0x18AFD90 VA: 0x1818B0990
	public int IndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B1180 Offset: 0x18B0580 VA: 0x1818B1180
	public int IndexOf(string value) { }

	// RVA: 0x18B0FC0 Offset: 0x18B03C0 VA: 0x1818B0FC0
	public int IndexOf(string value, int startIndex) { }

	// RVA: 0x18B16F0 Offset: 0x18B0AF0 VA: 0x1818B16F0
	public int IndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B0F70 Offset: 0x18B0370 VA: 0x1818B0F70
	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	// RVA: 0x18B1320 Offset: 0x18B0720 VA: 0x1818B1320
	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B3070 Offset: 0x18B2470 VA: 0x1818B3070
	public int LastIndexOf(char value) { }

	// RVA: 0x18B30C0 Offset: 0x18B24C0 VA: 0x1818B30C0
	public int LastIndexOf(char value, int startIndex) { }

	// RVA: 0x18B2B10 Offset: 0x18B1F10 VA: 0x1818B2B10
	public int LastIndexOfAny(char[] anyOf) { }

	// RVA: 0x18B2B30 Offset: 0x18B1F30 VA: 0x1818B2B30
	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	// RVA: 0x18B30E0 Offset: 0x18B24E0 VA: 0x1818B30E0
	public int LastIndexOf(string value) { }

	// RVA: 0x18B3090 Offset: 0x18B2490 VA: 0x1818B3090
	public int LastIndexOf(string value, StringComparison comparisonType) { }

	// RVA: 0x18B2C60 Offset: 0x18B2060 VA: 0x1818B2C60
	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	// RVA: 0x18B3820 Offset: 0x18B2C20 VA: 0x1818B3820
	public string PadLeft(int totalWidth) { }

	// RVA: 0x18B3840 Offset: 0x18B2C40 VA: 0x1818B3840
	public string PadLeft(int totalWidth, char paddingChar) { }

	// RVA: 0x18B3880 Offset: 0x18B2C80 VA: 0x1818B3880
	public string PadRight(int totalWidth) { }

	// RVA: 0x18B3860 Offset: 0x18B2C60 VA: 0x1818B3860
	public string PadRight(int totalWidth, char paddingChar) { }

	// RVA: 0x18B4C00 Offset: 0x18B4000 VA: 0x1818B4C00
	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	// RVA: 0x18B4C80 Offset: 0x18B4080 VA: 0x1818B4C80
	public bool StartsWith(string value, StringComparison comparisonType) { }

	// RVA: 0x18B5A30 Offset: 0x18B4E30 VA: 0x1818B5A30
	public string ToLower() { }

	// RVA: 0x18B5B20 Offset: 0x18B4F20 VA: 0x1818B5B20
	public string ToLower(CultureInfo culture) { }

	// RVA: 0x18B5940 Offset: 0x18B4D40 VA: 0x1818B5940
	public string ToLowerInvariant() { }

	// RVA: 0x18B5CB0 Offset: 0x18B50B0 VA: 0x1818B5CB0
	public string ToUpper() { }

	// RVA: 0x18B5DA0 Offset: 0x18B51A0 VA: 0x1818B5DA0
	public string ToUpper(CultureInfo culture) { }

	// RVA: 0x18B5BC0 Offset: 0x18B4FC0 VA: 0x1818B5BC0
	public string ToUpperInvariant() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 3
	public override string ToString() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 21
	public string ToString(IFormatProvider provider) { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 5
	public object Clone() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0
	private static bool IsBOMWhitespace(char c) { }

	// RVA: 0x18B67B0 Offset: 0x18B5BB0 VA: 0x1818B67B0
	public string Trim() { }

	// RVA: 0x18B61C0 Offset: 0x18B55C0 VA: 0x1818B61C0
	private string TrimHelper(int trimType) { }

	// RVA: 0x18B5FB0 Offset: 0x18B53B0 VA: 0x1818B5FB0
	private string TrimHelper(char[] trimChars, int trimType) { }

	// RVA: 0x18AE920 Offset: 0x18ADD20 VA: 0x1818AE920
	private string CreateTrimmedString(int start, int end) { }

	// RVA: 0x18B1720 Offset: 0x18B0B20 VA: 0x1818B1720
	public string Insert(int startIndex, string value) { }

	// RVA: 0x18B4440 Offset: 0x18B3840 VA: 0x1818B4440
	public string Replace(char oldChar, char newChar) { }

	// RVA: 0x18B4590 Offset: 0x18B3990 VA: 0x1818B4590
	public string Replace(string oldValue, string newValue) { }

	// RVA: 0x18B38A0 Offset: 0x18B2CA0 VA: 0x1818B38A0
	public string Remove(int startIndex, int count) { }

	// RVA: 0x18B3A60 Offset: 0x18B2E60 VA: 0x1818B3A60
	public string Remove(int startIndex) { }

	// RVA: 0x18AFE20 Offset: 0x18AF220 VA: 0x1818AFE20
	public static string Format(string format, object arg0) { }

	// RVA: 0x18AFF30 Offset: 0x18AF330 VA: 0x1818AFF30
	public static string Format(string format, object arg0, object arg1) { }

	// RVA: 0x18B0040 Offset: 0x18AF440 VA: 0x1818B0040
	public static string Format(string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B03A0 Offset: 0x18AF7A0 VA: 0x1818B03A0
	public static string Format(string format, object[] args) { }

	// RVA: 0x18B0150 Offset: 0x18AF550 VA: 0x1818B0150
	public static string Format(IFormatProvider provider, string format, object arg0) { }

	// RVA: 0x18B0270 Offset: 0x18AF670 VA: 0x1818B0270
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	// RVA: 0x18B0520 Offset: 0x18AF920 VA: 0x1818B0520
	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	// RVA: 0x18B0660 Offset: 0x18AFA60 VA: 0x1818B0660
	public static string Format(IFormatProvider provider, string format, object[] args) { }

	// RVA: 0x18AFD40 Offset: 0x18AF140 VA: 0x1818AFD40
	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	// RVA: 0x18AE250 Offset: 0x18AD650 VA: 0x1818AE250
	public static string Copy(string str) { }

	// RVA: 0x18AD470 Offset: 0x18AC870 VA: 0x1818AD470
	public static string Concat(object arg0) { }

	// RVA: 0x18AD8D0 Offset: 0x18ACCD0 VA: 0x1818AD8D0
	public static string Concat(object arg0, object arg1) { }

	// RVA: 0x18AD380 Offset: 0x18AC780 VA: 0x1818AD380
	public static string Concat(object arg0, object arg1, object arg2) { }

	// RVA: 0x18AD690 Offset: 0x18ACA90 VA: 0x1818AD690
	public static string Concat(object[] args) { }

	// RVA: 0x18AD4D0 Offset: 0x18AC8D0 VA: 0x1818AD4D0
	public static string Concat(string str0, string str1) { }

	// RVA: 0x18ADC60 Offset: 0x18AD060 VA: 0x1818ADC60
	public static string Concat(string str0, string str1, string str2) { }

	// RVA: 0x18AD980 Offset: 0x18ACD80 VA: 0x1818AD980
	public static string Concat(string str0, string str1, string str2, string str3) { }

	// RVA: 0x18AD0A0 Offset: 0x18AC4A0 VA: 0x1818AD0A0
	private static string ConcatArray(string[] values, int totalLength) { }

	// RVA: 0x18AD1D0 Offset: 0x18AC5D0 VA: 0x1818AD1D0
	public static string Concat(string[] values) { }

	// RVA: 0x15280B0 Offset: 0x15274B0 VA: 0x1815280B0 Slot: 6
	public TypeCode GetTypeCode() { }

	// RVA: 0x18B5210 Offset: 0x18B4610 VA: 0x1818B5210 Slot: 7
	private bool System.IConvertible.ToBoolean(IFormatProvider provider) { }

	// RVA: 0x18B52F0 Offset: 0x18B46F0 VA: 0x1818B52F0 Slot: 8
	private char System.IConvertible.ToChar(IFormatProvider provider) { }

	// RVA: 0x18B5610 Offset: 0x18B4A10 VA: 0x1818B5610 Slot: 9
	private sbyte System.IConvertible.ToSByte(IFormatProvider provider) { }

	// RVA: 0x18B5280 Offset: 0x18B4680 VA: 0x1818B5280 Slot: 10
	private byte System.IConvertible.ToByte(IFormatProvider provider) { }

	// RVA: 0x18B54C0 Offset: 0x18B48C0 VA: 0x1818B54C0 Slot: 11
	private short System.IConvertible.ToInt16(IFormatProvider provider) { }

	// RVA: 0x18B5770 Offset: 0x18B4B70 VA: 0x1818B5770 Slot: 12
	private ushort System.IConvertible.ToUInt16(IFormatProvider provider) { }

	// RVA: 0x18B5530 Offset: 0x18B4930 VA: 0x1818B5530 Slot: 13
	private int System.IConvertible.ToInt32(IFormatProvider provider) { }

	// RVA: 0x18B57E0 Offset: 0x18B4BE0 VA: 0x1818B57E0 Slot: 14
	private uint System.IConvertible.ToUInt32(IFormatProvider provider) { }

	// RVA: 0x18B55A0 Offset: 0x18B49A0 VA: 0x1818B55A0 Slot: 15
	private long System.IConvertible.ToInt64(IFormatProvider provider) { }

	// RVA: 0x18B5850 Offset: 0x18B4C50 VA: 0x1818B5850 Slot: 16
	private ulong System.IConvertible.ToUInt64(IFormatProvider provider) { }

	// RVA: 0x18B5680 Offset: 0x18B4A80 VA: 0x1818B5680 Slot: 17
	private float System.IConvertible.ToSingle(IFormatProvider provider) { }

	// RVA: 0x18B5450 Offset: 0x18B4850 VA: 0x1818B5450 Slot: 18
	private double System.IConvertible.ToDouble(IFormatProvider provider) { }

	// RVA: 0x18B53D0 Offset: 0x18B47D0 VA: 0x1818B53D0 Slot: 19
	private Decimal System.IConvertible.ToDecimal(IFormatProvider provider) { }

	// RVA: 0x18B5360 Offset: 0x18B4760 VA: 0x1818B5360 Slot: 20
	private DateTime System.IConvertible.ToDateTime(IFormatProvider provider) { }

	// RVA: 0x18B56F0 Offset: 0x18B4AF0 VA: 0x1818B56F0 Slot: 22
	private object System.IConvertible.ToType(Type type, IFormatProvider provider) { }

	// RVA: 0x18B5150 Offset: 0x18B4550 VA: 0x1818B5150 Slot: 25
	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	// RVA: 0x18B51B0 Offset: 0x18B45B0 VA: 0x1818B51B0 Slot: 23
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public int get_Length() { }

	// RVA: 0x18ABEF0 Offset: 0x18AB2F0 VA: 0x1818ABEF0
	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	// RVA: 0x18B0E00 Offset: 0x18B0200 VA: 0x1818B0E00
	public int IndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B0BB0 Offset: 0x18AFFB0 VA: 0x1818B0BB0
	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B0CB0 Offset: 0x18B00B0 VA: 0x1818B0CB0
	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	// RVA: 0x18B09B0 Offset: 0x18AFDB0 VA: 0x1818B09B0
	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B0840 Offset: 0x18AFC40 VA: 0x1818B0840
	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B3110 Offset: 0x18B2510 VA: 0x1818B3110
	public int LastIndexOf(char value, int startIndex, int count) { }

	// RVA: 0x18B2B50 Offset: 0x18B1F50 VA: 0x1818B2B50
	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	// RVA: 0x18B2910 Offset: 0x18B1D10 VA: 0x1818B2910
	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B2850 Offset: 0x18B1C50 VA: 0x1818B2850
	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	// RVA: 0x18B6A90 Offset: 0x18B5E90 VA: 0x1818B6A90
	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	// RVA: 0x18B3CA0 Offset: 0x18B30A0 VA: 0x1818B3CA0
	private string ReplaceInternal(char oldChar, char newChar) { }

	// RVA: 0x18B3DF0 Offset: 0x18B31F0 VA: 0x1818B3DF0
	internal string ReplaceInternal(string oldValue, string newValue) { }

	// RVA: 0x18B3EF0 Offset: 0x18B32F0 VA: 0x1818B3EF0
	private string ReplaceUnchecked(string oldValue, string newValue) { }

	// RVA: 0x18B3B40 Offset: 0x18B2F40 VA: 0x1818B3B40
	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	// RVA: 0x18B3660 Offset: 0x18B2A60 VA: 0x1818B3660
	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	// RVA: 0x18B4BB0 Offset: 0x18B3FB0 VA: 0x1818B4BB0
	internal bool StartsWithOrdinalUnchecked(string value) { }

	// RVA: 0x18B1F00 Offset: 0x18B1300 VA: 0x1818B1F00
	internal bool IsAscii() { }

	// RVA: 0x18ABBF0 Offset: 0x18AAFF0 VA: 0x1818ABBF0
	internal static void CharCopy(char* dest, char* src, int count) { }

	// RVA: 0x18B69A0 Offset: 0x18B5DA0 VA: 0x1818B69A0
	private static void memset(byte* dest, int val, int len) { }

	// RVA: 0x18B6990 Offset: 0x18B5D90 VA: 0x1818B6990
	private static void memcpy(byte* dest, byte* src, int size) { }

	// RVA: 0x18B6810 Offset: 0x18B5C10 VA: 0x1818B6810
	internal static void bzero(byte* dest, int len) { }

	// RVA: 0x18B67D0 Offset: 0x18B5BD0 VA: 0x1818B67D0
	internal static void bzero_aligned_1(byte* dest, int len) { }

	// RVA: 0x18B67E0 Offset: 0x18B5BE0 VA: 0x1818B67E0
	internal static void bzero_aligned_2(byte* dest, int len) { }

	// RVA: 0x18B67F0 Offset: 0x18B5BF0 VA: 0x1818B67F0
	internal static void bzero_aligned_4(byte* dest, int len) { }

	// RVA: 0x18B6800 Offset: 0x18B5C00 VA: 0x1818B6800
	internal static void bzero_aligned_8(byte* dest, int len) { }

	// RVA: 0x18B6950 Offset: 0x18B5D50 VA: 0x1818B6950
	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	// RVA: 0x18B6960 Offset: 0x18B5D60 VA: 0x1818B6960
	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	// RVA: 0x18B6970 Offset: 0x18B5D70 VA: 0x1818B6970
	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	// RVA: 0x18B6980 Offset: 0x18B5D80 VA: 0x1818B6980
	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	// RVA: 0x18AE820 Offset: 0x18ADC20 VA: 0x1818AE820
	private string CreateString(sbyte* value) { }

	// RVA: 0x18AE590 Offset: 0x18AD990 VA: 0x1818AE590
	private string CreateString(sbyte* value, int startIndex, int length) { }

	// RVA: 0x18AE810 Offset: 0x18ADC10 VA: 0x1818AE810
	private string CreateString(char* value) { }

	// RVA: 0x18AE900 Offset: 0x18ADD00 VA: 0x1818AE900
	private string CreateString(char* value, int startIndex, int length) { }

	// RVA: 0x18AE910 Offset: 0x18ADD10 VA: 0x1818AE910
	private string CreateString(char[] val, int startIndex, int length) { }

	// RVA: 0x18AE4D0 Offset: 0x18AD8D0 VA: 0x1818AE4D0
	private string CreateString(char[] val) { }

	// RVA: 0x18AE3F0 Offset: 0x18AD7F0 VA: 0x1818AE3F0
	private string CreateString(char c, int count) { }

	// RVA: 0x18AE5B0 Offset: 0x18AD9B0 VA: 0x1818AE5B0
	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

