internal sealed class RegexCharClass // TypeDefIndex: 2608
{	// Fields
	private List<RegexCharClass.SingleRange> _rangelist; // 0x10
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

	// Properties
	internal bool CanMerge { get; }
	internal bool Negate { set; }

	// Methods

	// RVA: 0x14C73B0 Offset: 0x14C67B0 VA: 0x1814C73B0
	private static void .cctor() { }

	// RVA: 0x14CC940 Offset: 0x14CBD40 VA: 0x1814CC940
	internal void .ctor() { }

	// RVA: 0x14CC9E0 Offset: 0x14CBDE0 VA: 0x1814CC9E0
	private void .ctor(bool negate, List<RegexCharClass.SingleRange> ranges, StringBuilder categories, RegexCharClass subtraction) { }

	// RVA: 0x14CCA60 Offset: 0x14CBE60 VA: 0x1814CCA60
	internal bool get_CanMerge() { }

	// RVA: 0x139E1C0 Offset: 0x139D5C0 VA: 0x18139E1C0
	internal void set_Negate(bool value) { }

	// RVA: 0x14C5250 Offset: 0x14C4650 VA: 0x1814C5250
	internal void AddChar(char c) { }

	// RVA: 0x14C5060 Offset: 0x14C4460 VA: 0x1814C5060
	internal void AddCharClass(RegexCharClass cc) { }

	// RVA: 0x14C5810 Offset: 0x14C4C10 VA: 0x1814C5810
	private void AddSet(string set) { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	internal void AddSubtraction(RegexCharClass sub) { }

	// RVA: 0x14C5730 Offset: 0x14C4B30 VA: 0x1814C5730
	internal void AddRange(char first, char last) { }

	// RVA: 0x14C4E10 Offset: 0x14C4210 VA: 0x1814C4E10
	internal void AddCategoryFromName(string categoryName, bool invert, bool caseInsensitive, string pattern) { }

	// RVA: 0x14C5040 Offset: 0x14C4440 VA: 0x1814C5040
	private void AddCategory(string category) { }

	// RVA: 0x14C55F0 Offset: 0x14C49F0 VA: 0x1814C55F0
	internal void AddLowercase(CultureInfo culture) { }

	// RVA: 0x14C5300 Offset: 0x14C4700 VA: 0x1814C5300
	private void AddLowercaseRange(char chMin, char chMax, CultureInfo culture) { }

	// RVA: 0x14C5B20 Offset: 0x14C4F20 VA: 0x1814C5B20
	internal void AddWord(bool ecma, bool negate) { }

	// RVA: 0x14C5A00 Offset: 0x14C4E00 VA: 0x1814C5A00
	internal void AddSpace(bool ecma, bool negate) { }

	// RVA: 0x14C5260 Offset: 0x14C4660 VA: 0x1814C5260
	internal void AddDigit(bool ecma, bool negate, string pattern) { }

	// RVA: 0x14C71A0 Offset: 0x14C65A0 VA: 0x1814C71A0
	internal static char SingletonChar(string set) { }

	// RVA: 0x14C6670 Offset: 0x14C5A70 VA: 0x1814C6670
	internal static bool IsMergeable(string charClass) { }

	// RVA: 0x14C6580 Offset: 0x14C5980 VA: 0x1814C6580
	internal static bool IsEmpty(string charClass) { }

	// RVA: 0x14C68C0 Offset: 0x14C5CC0 VA: 0x1814C68C0
	internal static bool IsSingleton(string set) { }

	// RVA: 0x14C6780 Offset: 0x14C5B80 VA: 0x1814C6780
	internal static bool IsSingletonInverse(string set) { }

	// RVA: 0x14C6A00 Offset: 0x14C5E00 VA: 0x1814C6A00
	private static bool IsSubtraction(string charClass) { }

	// RVA: 0x14C6750 Offset: 0x14C5B50 VA: 0x1814C6750
	internal static bool IsNegated(string set) { }

	// RVA: 0x14C64D0 Offset: 0x14C58D0 VA: 0x1814C64D0
	internal static bool IsECMAWordChar(char ch) { }

	// RVA: 0x14C6A60 Offset: 0x14C5E60 VA: 0x1814C6A60
	internal static bool IsWordChar(char ch) { }

	// RVA: 0x14C6400 Offset: 0x14C5800 VA: 0x1814C6400
	internal static bool CharInClass(char ch, string set) { }

	// RVA: 0x14C6210 Offset: 0x14C5610 VA: 0x1814C6210
	internal static bool CharInClassRecursive(char ch, string set, int start) { }

	// RVA: 0x14C6110 Offset: 0x14C5510 VA: 0x1814C6110
	private static bool CharInClassInternal(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C5F70 Offset: 0x14C5370 VA: 0x1814C5F70
	private static bool CharInCategory(char ch, string set, int start, int mySetLength, int myCategoryLength) { }

	// RVA: 0x14C5EA0 Offset: 0x14C52A0 VA: 0x1814C5EA0
	private static bool CharInCategoryGroup(char ch, UnicodeCategory chcategory, string category, ref int i) { }

	// RVA: 0x14C6B40 Offset: 0x14C5F40 VA: 0x1814C6B40
	private static string NegateCategory(string category) { }

	// RVA: 0x14C6E50 Offset: 0x14C6250 VA: 0x1814C6E50
	internal static RegexCharClass Parse(string charClass) { }

	// RVA: 0x14C6C10 Offset: 0x14C6010 VA: 0x1814C6C10
	private static RegexCharClass ParseRecursive(string charClass, int start) { }

	// RVA: 0x14C6EB0 Offset: 0x14C62B0 VA: 0x1814C6EB0
	private int RangeCount() { }

	// RVA: 0x14C71C0 Offset: 0x14C65C0 VA: 0x1814C71C0
	internal string ToStringClass() { }

	// RVA: 0x14C6470 Offset: 0x14C5870 VA: 0x1814C6470
	private RegexCharClass.SingleRange GetRangeAt(int i) { }

	// RVA: 0x14C5C40 Offset: 0x14C5040 VA: 0x1814C5C40
	private void Canonicalize() { }

	// RVA: 0x14C6EF0 Offset: 0x14C62F0 VA: 0x1814C6EF0
	private static string SetFromProperty(string capname, bool invert, string pattern) { }

}

private struct RegexCharClass.LowerCaseMapping // TypeDefIndex: 2609
{	// Fields
	internal char _chMin; // 0x0
	internal char _chMax; // 0x2
	internal int _lcOp; // 0x4
	internal int _data; // 0x8

	// Methods

	// RVA: 0x1F0AA0 Offset: 0x1EFEA0 VA: 0x1801F0AA0
	internal void .ctor(char chMin, char chMax, int lcOp, int data) { }

}

private sealed class RegexCharClass.SingleRangeComparer : IComparer<RegexCharClass.SingleRange> // TypeDefIndex: 2610
{	// Methods

	// RVA: 0x14D18C0 Offset: 0x14D0CC0 VA: 0x1814D18C0 Slot: 4
	public int Compare(RegexCharClass.SingleRange x, RegexCharClass.SingleRange y) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private sealed class RegexCharClass.SingleRange // TypeDefIndex: 2611
{	// Fields
	internal char _first; // 0x10
	internal char _last; // 0x12

	// Methods

	// RVA: 0x14D1900 Offset: 0x14D0D00 VA: 0x1814D1900
	internal void .ctor(char first, char last) { }

}

