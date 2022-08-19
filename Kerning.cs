public struct KerningPairKey // TypeDefIndex: 6766
{	// Fields
	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8

	// Methods

	// RVA: 0x117370 Offset: 0x116770 VA: 0x180117370
	public void .ctor(uint ascii_left, uint ascii_right) { }

}

public class KerningPair // TypeDefIndex: 6768
{	// Fields
	[FormerlySerializedAsAttribute] // RVA: 0xCC180 Offset: 0xCB580 VA: 0x1800CC180
	[SerializeField] // RVA: 0xCC180 Offset: 0xCB580 VA: 0x1800CC180
	private uint m_FirstGlyph; // 0x10
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments; // 0x14
	[FormerlySerializedAsAttribute] // RVA: 0xCC4D0 Offset: 0xCB8D0 VA: 0x1800CC4D0
	[SerializeField] // RVA: 0xCC4D0 Offset: 0xCB8D0 VA: 0x1800CC4D0
	private uint m_SecondGlyph; // 0x24
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xCC7A0 Offset: 0xCBBA0 VA: 0x1800CC7A0
	public float xOffset; // 0x38
	internal static KerningPair empty; // 0x0
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool m_IgnoreSpacingAdjustments; // 0x3C

	// Properties
	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }

	// Methods

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public uint get_firstGlyph() { }

	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_firstGlyph(uint value) { }

	// RVA: 0xC45080 Offset: 0xC44480 VA: 0x180C45080
	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	// RVA: 0x7E8DA0 Offset: 0x7E81A0 VA: 0x1807E8DA0
	public uint get_secondGlyph() { }

	// RVA: 0x7E8E00 Offset: 0x7E8200 VA: 0x1807E8E00
	public void set_secondGlyph(uint value) { }

	// RVA: 0xB0C9B0 Offset: 0xB0BDB0 VA: 0x180B0C9B0
	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	// RVA: 0xC45090 Offset: 0xC44490 VA: 0x180C45090
	public bool get_ignoreSpacingAdjustments() { }

	// RVA: 0xC45050 Offset: 0xC44450 VA: 0x180C45050
	public void .ctor() { }

	// RVA: 0xC45000 Offset: 0xC44400 VA: 0x180C45000
	public void .ctor(uint left, uint right, float offset) { }

	// RVA: 0xC44FA0 Offset: 0xC443A0 VA: 0x180C44FA0
	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	// RVA: 0xC44F10 Offset: 0xC44310 VA: 0x180C44F10
	internal void ConvertLegacyKerningData() { }

	// RVA: 0xC44F20 Offset: 0xC44320 VA: 0x180C44F20
	private static void .cctor() { }

}

public class KerningTable // TypeDefIndex: 6769
{	// Fields
	public List<KerningPair> kerningPairs; // 0x10

	// Methods

	// RVA: 0xC45770 Offset: 0xC44B70 VA: 0x180C45770
	public void .ctor() { }

	// RVA: 0xC451E0 Offset: 0xC445E0 VA: 0x180C451E0
	public void AddKerningPair() { }

	// RVA: 0xC45310 Offset: 0xC44710 VA: 0x180C45310
	public int AddKerningPair(uint first, uint second, float offset) { }

	// RVA: 0xC450A0 Offset: 0xC444A0 VA: 0x180C450A0
	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	// RVA: 0xC45490 Offset: 0xC44890 VA: 0x180C45490
	public void RemoveKerningPair(int left, int right) { }

	// RVA: 0xC45430 Offset: 0xC44830 VA: 0x180C45430
	public void RemoveKerningPair(int index) { }

	// RVA: 0xC45570 Offset: 0xC44970 VA: 0x180C45570
	public void SortKerningPairs() { }

}

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6770
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC644B0 Offset: 0xC638B0 VA: 0x180C644B0
	internal bool <AddKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6771
{	// Fields
	public uint first; // 0x10
	public uint second; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC644B0 Offset: 0xC638B0 VA: 0x180C644B0
	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6772
{	// Fields
	public int left; // 0x10
	public int right; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0xC644E0 Offset: 0xC638E0 VA: 0x180C644E0
	internal bool <RemoveKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c // TypeDefIndex: 6773
{	// Fields
	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10

	// Methods

	// RVA: 0xC64580 Offset: 0xC63980 VA: 0x180C64580
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x7B2BC0 Offset: 0x7B1FC0 VA: 0x1807B2BC0
	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	// RVA: 0x4D2220 Offset: 0x4D1620 VA: 0x1804D2220
	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

}

