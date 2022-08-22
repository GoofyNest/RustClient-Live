internal sealed class RegexCharClass // TypeDefIndex: 2608
{	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
	private StringBuilder _categories; // 0x18
	private bool _canonical; // 0x20
	private bool _negate; // 0x21
	private RegexCharClass _subtractor; // 0x28
	private static readonly string InternalRegexIgnoreCase; // 0x0
	private static readonly string Space; // 0x8
	private static readonly string NotSpace; // 0x10
	private static readonly string Word; // 0x18
	private static readonly string NotWord; // 0x20
	internal static readonly string SpaceClass; // 0x28
	internal static readonly string NotSpaceClass; // 0x30
	internal static readonly string WordClass; // 0x38
	internal static readonly string NotWordClass; // 0x40
	internal static readonly string DigitClass; // 0x48
	internal static readonly string NotDigitClass; // 0x50
	private static Dictionary<string, string> _definedCategories; // 0x58
	private static readonly string[,] _propTable; // 0x60
	private static readonly RegexCharClass.LowerCaseMapping[] _lcTable; // 0x68

	internal bool CanMerge { get; }
	internal bool Negate { set; }


	private static void .cctor() { }

	internal void .ctor() { }

	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	internal bool get_CanMerge() { }

	internal void set_Negate(bool value) { }

	internal void AddChar(char c) { }

	internal void AddCharClass(RegexCharClass cc) { }

	private void AddSet(string set) { }

	internal void AddSubtraction(RegexCharClass sub) { }

	internal void AddRange(char first, char last) { }

	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	private void AddCategory(string category) { }

	internal void AddLowercase(CultureInfo culture) { }

	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	internal void AddWord(bool ecma, bool negate) { }

	internal void AddSpace(bool ecma, bool negate) { }

	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	internal static char SingletonChar(string set) { }

	internal static bool IsMergeable(string charClass) { }

	internal static bool IsEmpty(string charClass) { }

	internal static bool IsSingleton(string set) { }

	internal static bool IsSingletonInverse(string set) { }

	private static bool IsSubtraction(string charClass) { }

	internal static bool IsNegated(string set) { }

	internal static bool IsECMAWordChar(char ch) { }

	internal static bool IsWordChar(char ch) { }

	internal static bool CharInClass(char ch, string set) { }

	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	private static string NegateCategory(string category) { }

	internal static RegexCharClass Parse(string charClass) { }

	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	private int RangeCount() { }

	internal string ToStringClass() { }

	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	private void Canonicalize() { }

	private static string SetFromProperty(string capname, bool invert, string pattern) { }

}

private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2609
{	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8


	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }

}

private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2610
{
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	public void .ctor() { }

}

private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2611
{	internal char _first; // 0x10
	internal char _last; // 0x12


	internal void .ctor(char first, char last) { }

}

