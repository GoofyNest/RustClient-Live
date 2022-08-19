internal class MSCompatUnicodeTable // TypeDefIndex: 35
{	// Fields
	public static int MaxExpansionLength; // 0x0
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

	// Properties
	public static bool IsReady { get; }

	// Methods

	// RVA: 0x163FB50 Offset: 0x163EF50 VA: 0x18163FB50
	public static TailoringInfo GetTailoringInfo(int lcid) { }

	// RVA: 0x163ED40 Offset: 0x163E140 VA: 0x18163ED40
	public static void BuildTailoringTables(CultureInfo culture, TailoringInfo t, ref Contraction[] contractions, ref Level2Map[] diacriticals) { }

	// RVA: 0x1640290 Offset: 0x163F690 VA: 0x181640290
	private static void SetCJKReferences(string name, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x163F310 Offset: 0x163E710 VA: 0x18163F310
	public static byte Category(int cp) { }

	// RVA: 0x1640050 Offset: 0x163F450 VA: 0x181640050
	public static byte Level1(int cp) { }

	// RVA: 0x1640110 Offset: 0x163F510 VA: 0x181640110
	public static byte Level2(int cp) { }

	// RVA: 0x16401D0 Offset: 0x163F5D0 VA: 0x1816401D0
	public static byte Level3(int cp) { }

	// RVA: 0x163FDB0 Offset: 0x163F1B0 VA: 0x18163FDB0
	public static bool IsIgnorable(int cp, byte flag) { }

	// RVA: 0x163FD50 Offset: 0x163F150 VA: 0x18163FD50
	public static bool IsIgnorableNonSpacing(int cp) { }

	// RVA: 0x1640570 Offset: 0x163F970 VA: 0x181640570
	public static int ToKanaTypeInsensitive(int i) { }

	// RVA: 0x1640590 Offset: 0x163F990 VA: 0x181640590
	public static int ToWidthCompat(int i) { }

	// RVA: 0x163FCA0 Offset: 0x163F0A0 VA: 0x18163FCA0
	public static bool HasSpecialWeight(char c) { }

	// RVA: 0x163FD10 Offset: 0x163F110 VA: 0x18163FD10
	public static bool IsHalfWidthKana(char c) { }

	// RVA: 0x163FD30 Offset: 0x163F130 VA: 0x18163FD30
	public static bool IsHiragana(char c) { }

	// RVA: 0x163FEE0 Offset: 0x163F2E0 VA: 0x18163FEE0
	public static bool IsJapaneseSmallLetter(char c) { }

	// RVA: 0x1640CD0 Offset: 0x16400D0 VA: 0x181640CD0
	public static bool get_IsReady() { }

	// RVA: 0x163FAE0 Offset: 0x163EEE0 VA: 0x18163FAE0
	private static IntPtr GetResource(string name) { }

	// RVA: 0x1640710 Offset: 0x163FB10 VA: 0x181640710
	private static uint UInt32FromBytePtr(byte* raw, uint idx) { }

	// RVA: 0x1640750 Offset: 0x163FB50 VA: 0x181640750
	private static void .cctor() { }

	// RVA: 0x163F960 Offset: 0x163ED60 VA: 0x18163F960
	public static void FillCJK(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer lv2Indexer, ref byte* lv2Table) { }

	// RVA: 0x163F3D0 Offset: 0x163E7D0 VA: 0x18163F3D0
	private static void FillCJKCore(string culture, ref CodePointIndexer cjkIndexer, ref byte* catTable, ref byte* lv1Table, ref CodePointIndexer cjkLv2Indexer, ref byte* lv2Table) { }

}

private sealed class MSCompatUnicodeTable.<>c // TypeDefIndex: 36
{	// Fields
	public static readonly MSCompatUnicodeTable.<>c <>9; // 0x0
	public static Comparison<Level2Map> <>9__17_0; // 0x8

	// Methods

	// RVA: 0x164C6C0 Offset: 0x164BAC0 VA: 0x18164C6C0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x164C690 Offset: 0x164BA90 VA: 0x18164C690
	internal int <BuildTailoringTables>b__17_0(Level2Map a, Level2Map b) { }

}

