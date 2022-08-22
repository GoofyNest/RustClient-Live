internal class SimpleCollator // TypeDefIndex: 39
{	private static bool QuickCheckDisabled; // 0x0
	private static SimpleCollator invariant; // 0x8
	private readonly TextInfo textInfo; // 0x10
	private readonly CodePointIndexer cjkIndexer; // 0x18
	private readonly Contraction[] contractions; // 0x20
	private readonly Level2Map[] level2Maps; // 0x28
	private readonly byte[] unsafeFlags; // 0x30
	private readonly byte* cjkCatTable; // 0x38
	private readonly byte* cjkLv1Table; // 0x40
	private readonly byte* cjkLv2Table; // 0x48
	private readonly CodePointIndexer cjkLv2Indexer; // 0x50
	private readonly int lcid; // 0x58
	private readonly bool frenchSort; // 0x5C
	private const int UnsafeFlagLength = 96;


	public void .ctor(CultureInfo culture) { }

	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	private byte Category(int cp) { }

	private byte Level1(int cp) { }

	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	private Contraction GetContraction(string s, int start, int end) { }

	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	private Contraction GetTailContraction(string s, int start, int end) { }

	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	private int FilterOptions(int i, CompareOptions opt) { }

	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	private static bool IsIgnorable(int i, CompareOptions opt) { }

	private bool IsSafe(int i) { }

	public SortKey GetSortKey(string s, CompareOptions options) { }

	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	private void ClearBuffer(byte* buffer, int size) { }

	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	private int CompareFlagPair(bool b1, bool b2) { }

	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	private static void .cctor() { }

}

internal struct SimpleCollator.Context // TypeDefIndex: 40
{	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30


	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }

}

private struct SimpleCollator.PreviousInfo // TypeDefIndex: 41
{	public int Code; // 0x0
	public byte* SortKey; // 0x8


	public void .ctor(bool dummy) { }

}

private struct SimpleCollator.Escape // TypeDefIndex: 42
{	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14

}

private enum SimpleCollator.ExtenderType // TypeDefIndex: 43
{	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;

}

