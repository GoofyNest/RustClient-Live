public sealed class String : IComparable, ICloneable, IConvertible, IEnumerable, IComparable<string>, IEnumerable<char>, IEquatable<string> // TypeDefIndex: 301
{	private int m_stringLength; // 0x10
	private char m_firstChar; // 0x14
	private const int TrimHead = 0;
	private const int TrimTail = 1;
	private const int TrimBoth = 2;
	public static readonly string Empty; // 0x0
	private const int charPtrAlignConst = 1;
	private const int alignConst = 3;

	public char Chars { get; }
	public int Length { get; }


	public static string Join(string separator, string[] value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public static string Join(string separator, object[] values) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public static string Join<T>(string separator, IEnumerable<T> values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0xE83DC0 Offset: 0xE831C0 VA: 0x180E83DC0
	|-String.Join<object>
	*/

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public static string Join(string separator, IEnumerable<string> values) { }

	public static string Join(string separator, string[] value, int startIndex, int count) { }

	private static int CompareOrdinalIgnoreCaseHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	private static bool EqualsHelper(string strA, string strB) { }

	private static int CompareOrdinalHelper(string strA, string strB) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public override bool Equals(object obj) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public bool Equals(string value) { }

	public bool Equals(string value, StringComparison comparisonType) { }

	public static bool Equals(string a, string b) { }

	public static bool Equals(string a, string b, StringComparison comparisonType) { }

	public static bool op_Equality(string a, string b) { }

	public static bool op_Inequality(string a, string b) { }

	public char get_Chars(int index) { }

	public void CopyTo(int sourceIndex, char[] destination, int destinationIndex, int count) { }

	public char[] ToCharArray() { }

	public static bool IsNullOrEmpty(string value) { }

	public static bool IsNullOrWhiteSpace(string value) { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	public override int GetHashCode() { }

	[ReliabilityContractAttribute] // RVA: 0x83C10 Offset: 0x83010 VA: 0x180083C10
	internal int GetLegacyNonRandomizedHashCode() { }

	public string[] Split(char[] separator) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public string[] Split(char[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	internal string[] SplitInternal(char[] separator, int count, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public string[] Split(string[] separator, StringSplitOptions options) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public string[] Split(string[] separator, int count, StringSplitOptions options) { }

	private string[] InternalSplitKeepEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	private string[] InternalSplitOmitEmptyEntries(int[] sepList, int[] lengthList, int numReplaces, int count) { }

	private int MakeSeparatorList(char[] separator, ref int[] sepList) { }

	private int MakeSeparatorList(string[] separators, ref int[] sepList, ref int[] lengthList) { }

	public string Substring(int startIndex) { }

	public string Substring(int startIndex, int length) { }

	private string InternalSubString(int startIndex, int length) { }

	public string Trim(char[] trimChars) { }

	public string TrimStart(char[] trimChars) { }

	public string TrimEnd(char[] trimChars) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(char* value) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(char* value, int startIndex, int length) { }

	[CLSCompliantAttribute] // RVA: 0x6F340 Offset: 0x6E740 VA: 0x18006F340
	public void .ctor(sbyte* value, int startIndex, int length, Encoding enc) { }

	internal static string CreateStringFromEncoding(byte* bytes, int byteLength, Encoding encoding) { }

	public string Normalize(NormalizationForm normalizationForm) { }

	internal static string FastAllocateString(int length) { }

	private static void FillStringChecked(string dest, int destPos, string src) { }

	public void .ctor(char[] value, int startIndex, int length) { }

	public void .ctor(char[] value) { }

	internal static void wstrcpy(char* dmem, char* smem, int charCount) { }

	private string CtorCharArray(char[] value) { }

	private string CtorCharArrayStartLength(char[] value, int startIndex, int length) { }

	private static int wcslen(char* ptr) { }

	private string CtorCharPtr(char* ptr) { }

	private string CtorCharPtrStartLength(char* ptr, int startIndex, int length) { }

	public void .ctor(char c, int count) { }

	public static int Compare(string strA, string strB, bool ignoreCase) { }

	public static int Compare(string strA, string strB, StringComparison comparisonType) { }

	public static int Compare(string strA, string strB, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, bool ignoreCase, CultureInfo culture) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, CultureInfo culture, CompareOptions options) { }

	public static int Compare(string strA, int indexA, string strB, int indexB, int length, StringComparison comparisonType) { }

	public int CompareTo(object value) { }

	public int CompareTo(string strB) { }

	public static int CompareOrdinal(string strA, string strB) { }

	public static int CompareOrdinal(string strA, int indexA, string strB, int indexB, int length) { }

	public bool Contains(string value) { }

	public bool EndsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool EndsWith(string value, StringComparison comparisonType) { }

	internal bool EndsWith(char value) { }

	public int IndexOf(char value) { }

	public int IndexOf(char value, int startIndex) { }

	public int IndexOfAny(char[] anyOf) { }

	public int IndexOfAny(char[] anyOf, int startIndex) { }

	public int IndexOf(string value) { }

	public int IndexOf(string value, int startIndex) { }

	public int IndexOf(string value, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex, StringComparison comparisonType) { }

	public int IndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public int LastIndexOf(char value) { }

	public int LastIndexOf(char value, int startIndex) { }

	public int LastIndexOfAny(char[] anyOf) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex) { }

	public int LastIndexOf(string value) { }

	public int LastIndexOf(string value, StringComparison comparisonType) { }

	public int LastIndexOf(string value, int startIndex, int count, StringComparison comparisonType) { }

	public string PadLeft(int totalWidth) { }

	public string PadLeft(int totalWidth, char paddingChar) { }

	public string PadRight(int totalWidth) { }

	public string PadRight(int totalWidth, char paddingChar) { }

	public bool StartsWith(string value) { }

	[ComVisibleAttribute] // RVA: 0x75C30 Offset: 0x75030 VA: 0x180075C30
	public bool StartsWith(string value, StringComparison comparisonType) { }

	public string ToLower() { }

	public string ToLower(CultureInfo culture) { }

	public string ToLowerInvariant() { }

	public string ToUpper() { }

	public string ToUpper(CultureInfo culture) { }

	public string ToUpperInvariant() { }

	public override string ToString() { }

	public string ToString(IFormatProvider provider) { }

	public object Clone() { }

	private static bool IsBOMWhitespace(char c) { }

	public string Trim() { }

	private string TrimHelper(int trimType) { }

	private string TrimHelper(char[] trimChars, int trimType) { }

	private string CreateTrimmedString(int start, int end) { }

	public string Insert(int startIndex, string value) { }

	public string Replace(char oldChar, char newChar) { }

	public string Replace(string oldValue, string newValue) { }

	public string Remove(int startIndex, int count) { }

	public string Remove(int startIndex) { }

	public static string Format(string format, object arg0) { }

	public static string Format(string format, object arg0, object arg1) { }

	public static string Format(string format, object arg0, object arg1, object arg2) { }

	public static string Format(string format, object[] args) { }

	public static string Format(IFormatProvider provider, string format, object arg0) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1) { }

	public static string Format(IFormatProvider provider, string format, object arg0, object arg1, object arg2) { }

	public static string Format(IFormatProvider provider, string format, object[] args) { }

	private static string FormatHelper(IFormatProvider provider, string format, ParamsArray args) { }

	public static string Copy(string str) { }

	public static string Concat(object arg0) { }

	public static string Concat(object arg0, object arg1) { }

	public static string Concat(object arg0, object arg1, object arg2) { }

	public static string Concat(object[] args) { }

	public static string Concat(string str0, string str1) { }

	public static string Concat(string str0, string str1, string str2) { }

	public static string Concat(string str0, string str1, string str2, string str3) { }

	private static string ConcatArray(string[] values, int totalLength) { }

	public static string Concat(string[] values) { }

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

	private IEnumerator<char> System.Collections.Generic.IEnumerable<System.Char>.GetEnumerator() { }

	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	public int get_Length() { }

	internal static int CompareOrdinalUnchecked(string strA, int indexA, int lenA, string strB, int indexB, int lenB) { }

	public int IndexOf(char value, int startIndex, int count) { }

	internal int IndexOfUnchecked(char value, int startIndex, int count) { }

	internal int IndexOfUnchecked(string value, int startIndex, int count) { }

	public int IndexOfAny(char[] anyOf, int startIndex, int count) { }

	private int IndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	public int LastIndexOf(char value, int startIndex, int count) { }

	internal int LastIndexOfUnchecked(char value, int startIndex, int count) { }

	public int LastIndexOfAny(char[] anyOf, int startIndex, int count) { }

	private int LastIndexOfAnyUnchecked(char[] anyOf, int startIndex, int count) { }

	internal static int nativeCompareOrdinalEx(string strA, int indexA, string strB, int indexB, int count) { }

	private string ReplaceInternal(char oldChar, char newChar) { }

	internal string ReplaceInternal(string oldValue, string newValue) { }

	private string ReplaceUnchecked(string oldValue, string newValue) { }

	private string ReplaceFallback(string oldValue, string newValue, int testedCount) { }

	private string PadHelper(int totalWidth, char paddingChar, bool isRightPadded) { }

	internal bool StartsWithOrdinalUnchecked(string value) { }

	internal bool IsAscii() { }

	internal static void CharCopy(char* dest, char* src, int count) { }

	private static void memset(byte* dest, int val, int len) { }

	private static void memcpy(byte* dest, byte* src, int size) { }

	internal static void bzero(byte* dest, int len) { }

	internal static void bzero_aligned_1(byte* dest, int len) { }

	internal static void bzero_aligned_2(byte* dest, int len) { }

	internal static void bzero_aligned_4(byte* dest, int len) { }

	internal static void bzero_aligned_8(byte* dest, int len) { }

	internal static void memcpy_aligned_1(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_2(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_4(byte* dest, byte* src, int size) { }

	internal static void memcpy_aligned_8(byte* dest, byte* src, int size) { }

	private string CreateString(sbyte* value) { }

	private string CreateString(sbyte* value, int startIndex, int length) { }

	private string CreateString(char* value) { }

	private string CreateString(char* value, int startIndex, int length) { }

	private string CreateString(char[] val, int startIndex, int length) { }

	private string CreateString(char[] val) { }

	private string CreateString(char c, int count) { }

	private string CreateString(sbyte* value, int startIndex, int length, Encoding enc) { }

}

