internal class MSCompatUnicodeTable // TypeDefIndex: 35
{
	public static int MaxExpansionLength; 
	private static readonly byte* ignorableFlags; 
	private static readonly byte* categories; 
	private static readonly byte* level1; 
	private static readonly byte* level2; 
	private static readonly byte* level3; 
	private static byte* cjkCHScategory; 
	private static byte* cjkCHTcategory; 
	private static byte* cjkJAcategory; 
	private static byte* cjkKOcategory; 
	private static byte* cjkCHSlv1; 
	private static byte* cjkCHTlv1; 
	private static byte* cjkJAlv1; 
	private static byte* cjkKOlv1; 
	private static byte* cjkKOlv2; 
	private static readonly char[] tailoringArr; 
	private static readonly TailoringInfo[] tailoringInfos; 
	private static object forLock; 
	public static readonly bool isReady; 

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
{
	public static readonly MSCompatUnicodeTable.<>c <>9; 
	public static Comparison<Level2Map> <>9__17_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <BuildTailoringTables>

}

