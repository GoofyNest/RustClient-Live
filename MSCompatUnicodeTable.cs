internal class MSCompatUnicodeTable // TypeDefIndex: 35
{	public static int MaxExpansionLength; // 0x0
	private static readonly byte* ignorableFlags; // 0x8
	private static readonly byte* categories; // 0x10
	private static readonly byte* level1; // 0x18
	private static readonly byte* level2; // 0x20
	private static readonly byte* level3; // 0x28
	private static byte* cjkCHScategory; // 0x30
	private static byte* cjkCHTcategory; // 0x38
	private static byte* cjkJAcategory; // 0x40
	private static byte* cjkKOcategory; // 0x48
	private static byte* cjkCHSlv1; // 0x50
	private static byte* cjkCHTlv1; // 0x58
	private static byte* cjkJAlv1; // 0x60
	private static byte* cjkKOlv1; // 0x68
	private static byte* cjkKOlv2; // 0x70
	private static readonly char[] tailoringArr; // 0x78
	private static readonly TailoringInfo[] tailoringInfos; // 0x80
	private static object forLock; // 0x88
	public static readonly bool isReady; // 0x90

	public static bool IsReady { get; }


	public static TailoringInfo GetTailoringInfo(int lcid) { }

	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	public static byte Category(int cp) { }

	public static byte Level1(int cp) { }

	public static byte Level2(int cp) { }

	public static byte Level3(int cp) { }

	public static bool IsIgnorable(int cp, byte flag) { }

	public static bool IsIgnorableNonSpacing(int cp) { }

	public static int ToKanaTypeInsensitive(int i) { }

	public static int ToWidthCompat(int i) { }

	public static bool HasSpecialWeight(char c) { }

	public static bool IsHalfWidthKana(char c) { }

	public static bool IsHiragana(char c) { }

	public static bool IsJapaneseSmallLetter(char c) { }

	public static bool get_IsReady() { }

	private static IntPtr GetResource(string name) { }

	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	private static void .cctor() { }

	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }

}

private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 36
{	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

}

