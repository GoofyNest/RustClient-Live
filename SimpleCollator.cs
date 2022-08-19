internal class SimpleCollator // TypeDefIndex: 39
{	// Fields
	private static bool QuickCheckDisabled; // 0x0
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

	// Methods

	// RVA: 0x164B1D0 Offset: 0x164A5D0 VA: 0x18164B1D0
	public void .ctor(CultureInfo culture) { }

	// RVA: 0x164AF80 Offset: 0x164A380 VA: 0x18164AF80
	private void SetCJKTable(CultureInfo culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x1647C70 Offset: 0x1647070 VA: 0x181647C70
	private static CultureInfo GetNeutralCulture(CultureInfo info) { }

	// RVA: 0x1645BE0 Offset: 0x1644FE0 VA: 0x181645BE0
	private byte Category(int cp) { }

	// RVA: 0x1649C90 Offset: 0x1649090 VA: 0x181649C90
	private byte Level1(int cp) { }

	// RVA: 0x1649D30 Offset: 0x1649130 VA: 0x181649D30
	private byte Level2(int cp, SimpleCollator.ExtenderType ext) { }

	// RVA: 0x1648F50 Offset: 0x1648350 VA: 0x181648F50
	private static bool IsHalfKana(int cp, CompareOptions opt) { }

	// RVA: 0x1647990 Offset: 0x1646D90 VA: 0x181647990
	private Contraction GetContraction(string s, int start, int end) { }

	// RVA: 0x1647A70 Offset: 0x1646E70 VA: 0x181647A70
	private Contraction GetContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x1648270 Offset: 0x1647670 VA: 0x181648270
	private Contraction GetTailContraction(string s, int start, int end) { }

	// RVA: 0x1648350 Offset: 0x1647750 VA: 0x181648350
	private Contraction GetTailContraction(string s, int start, int end, Contraction[] clist) { }

	// RVA: 0x16476D0 Offset: 0x1646AD0 VA: 0x1816476D0
	private int FilterOptions(int i, CompareOptions opt) { }

	// RVA: 0x1647BC0 Offset: 0x1646FC0 VA: 0x181647BC0
	private SimpleCollator.ExtenderType GetExtenderType(int i) { }

	// RVA: 0x164B0E0 Offset: 0x164A4E0 VA: 0x18164B0E0
	private static byte ToDashTypeValue(SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x16474B0 Offset: 0x16468B0 VA: 0x1816474B0
	private int FilterExtender(int i, SimpleCollator.ExtenderType ext, CompareOptions opt) { }

	// RVA: 0x1648FE0 Offset: 0x16483E0 VA: 0x181648FE0
	private static bool IsIgnorable(int i, CompareOptions opt) { }

	// RVA: 0x1649230 Offset: 0x1648630 VA: 0x181649230
	private bool IsSafe(int i) { }

	// RVA: 0x1647D00 Offset: 0x1647100 VA: 0x181647D00
	public SortKey GetSortKey(string s, CompareOptions options) { }

	// RVA: 0x1647DF0 Offset: 0x16471F0 VA: 0x181647DF0
	public SortKey GetSortKey(string s, int start, int length, CompareOptions options) { }

	// RVA: 0x1647EF0 Offset: 0x16472F0 VA: 0x181647EF0
	private void GetSortKey(string s, int start, int end, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1646F60 Offset: 0x1646360 VA: 0x181646F60
	private void FillSortKeyRaw(int i, SimpleCollator.ExtenderType ext, SortKeyBuffer buf, CompareOptions opt) { }

	// RVA: 0x1647400 Offset: 0x1646800 VA: 0x181647400
	private void FillSurrogateSortKeyRaw(int i, SortKeyBuffer buf) { }

	// RVA: 0x1646E60 Offset: 0x1646260 VA: 0x181646E60
	internal int Compare(string s1, int idx1, int len1, string s2, int idx2, int len2, CompareOptions options) { }

	// RVA: 0x1645C80 Offset: 0x1645080 VA: 0x181645C80
	private void ClearBuffer(byte* buffer, int size) { }

	// RVA: 0x1645CC0 Offset: 0x16450C0 VA: 0x181645CC0
	private int CompareInternal(string s1, int idx1, int len1, string s2, int idx2, int len2, out bool targetConsumed, out bool sourceConsumed, bool skipHeadingExtenders, bool immediateBreakup, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1645CA0 Offset: 0x16450A0 VA: 0x181645CA0
	private int CompareFlagPair(bool b1, bool b2) { }

	// RVA: 0x1649070 Offset: 0x1648470 VA: 0x181649070
	public bool IsPrefix(string src, string target, CompareOptions opt) { }

	// RVA: 0x16490B0 Offset: 0x16484B0 VA: 0x1816490B0
	public bool IsPrefix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x16491B0 Offset: 0x16485B0 VA: 0x1816491B0
	private bool IsPrefix(string s, string target, int start, int length, bool skipHeadingExtenders, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1649360 Offset: 0x1648760 VA: 0x181649360
	public bool IsSuffix(string src, string target, CompareOptions opt) { }

	// RVA: 0x16492A0 Offset: 0x16486A0 VA: 0x1816492A0
	public bool IsSuffix(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x164AE40 Offset: 0x164A240 VA: 0x18164AE40
	private int QuickIndexOf(string s, string target, int start, int length, out bool testWasUnable) { }

	// RVA: 0x1648C90 Offset: 0x1648090 VA: 0x181648C90
	public int IndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1648600 Offset: 0x1647A00 VA: 0x181648600
	private int IndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1648580 Offset: 0x1647980 VA: 0x181648580
	private int IndexOfOrdinal(string s, char target, int start, int length) { }

	// RVA: 0x16486C0 Offset: 0x1647AC0 VA: 0x1816486C0
	private int IndexOfSortKey(string s, int start, int length, byte* sortkey, char target, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1648780 Offset: 0x1647B80 VA: 0x181648780
	private int IndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1649B00 Offset: 0x1648F00 VA: 0x181649B00
	public int LastIndexOf(string s, string target, int start, int length, CompareOptions opt) { }

	// RVA: 0x1649420 Offset: 0x1648820 VA: 0x181649420
	private int LastIndexOfOrdinal(string s, string target, int start, int length) { }

	// RVA: 0x1649550 Offset: 0x1648950 VA: 0x181649550
	private int LastIndexOfSortKey(string s, int start, int orgStart, int length, byte* sortkey, int ti, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1649620 Offset: 0x1648A20 VA: 0x181649620
	private int LastIndexOf(string s, string target, int start, int length, byte* targetSortKey, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164AA70 Offset: 0x1649E70 VA: 0x18164AA70
	private bool MatchesForward(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164A6C0 Offset: 0x1649AC0 VA: 0x18164A6C0
	private bool MatchesForwardCore(string s, ref int idx, int end, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164AC40 Offset: 0x164A040 VA: 0x18164AC40
	private bool MatchesPrimitive(CompareOptions opt, byte* source, int si, SimpleCollator.ExtenderType ext, byte* target, int ti, bool noLv4) { }

	// RVA: 0x164A4E0 Offset: 0x16498E0 VA: 0x18164A4E0
	private bool MatchesBackward(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, ref SimpleCollator.Context ctx) { }

	// RVA: 0x1649ED0 Offset: 0x16492D0 VA: 0x181649ED0
	private bool MatchesBackwardCore(string s, ref int idx, int end, int orgStart, int ti, byte* sortkey, bool noLv4, SimpleCollator.ExtenderType ext, ref Contraction ct, ref SimpleCollator.Context ctx) { }

	// RVA: 0x164B100 Offset: 0x164A500 VA: 0x18164B100
	private static void .cctor() { }

}

internal struct SimpleCollator.Context // TypeDefIndex: 40
{	// Fields
	public readonly CompareOptions Option; // 0x0
	public readonly byte* NeverMatchFlags; // 0x8
	public readonly byte* AlwaysMatchFlags; // 0x10
	public byte* Buffer1; // 0x18
	public byte* Buffer2; // 0x20
	public int PrevCode; // 0x28
	public byte* PrevSortKey; // 0x30

	// Methods

	// RVA: 0x1F6440 Offset: 0x1F5840 VA: 0x1801F6440
	public void .ctor(CompareOptions opt, byte* alwaysMatchFlags, byte* neverMatchFlags, byte* buffer1, byte* buffer2, byte* prev1) { }

}

private struct SimpleCollator.PreviousInfo // TypeDefIndex: 41
{	// Fields
	public int Code; // 0x0
	public byte* SortKey; // 0x8

	// Methods

	// RVA: 0x1F6560 Offset: 0x1F5960 VA: 0x1801F6560
	public void .ctor(bool dummy) { }

}

private struct SimpleCollator.Escape // TypeDefIndex: 42
{	// Fields
	public string Source; // 0x0
	public int Index; // 0x8
	public int Start; // 0xC
	public int End; // 0x10
	public int Optional; // 0x14

}

private enum SimpleCollator.ExtenderType // TypeDefIndex: 43
{	// Fields
	public int value__; // 0x0
	public const SimpleCollator.ExtenderType None = 0;
	public const SimpleCollator.ExtenderType Simple = 1;
	public const SimpleCollator.ExtenderType Voiced = 2;
	public const SimpleCollator.ExtenderType Conditional = 3;
	public const SimpleCollator.ExtenderType Buggy = 4;

}

