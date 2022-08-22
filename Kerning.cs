public struct KerningPairKey // TypeDefIndex: 6766
{	public uint ascii_Left; // 0x0
	public uint ascii_Right; // 0x4
	public uint key; // 0x8


	public void .ctor(uint ascii_left, uint ascii_right) { }

}

public class KerningPair // TypeDefIndex: 6768
{	[FormerlySerializedAsAttribute] // RVA: 0xCC180 Offset: 0xCB580 VA: 0x1800CC180
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

	public uint firstGlyph { get; set; }
	public GlyphValueRecord_Legacy firstGlyphAdjustments { get; }
	public uint secondGlyph { get; set; }
	public GlyphValueRecord_Legacy secondGlyphAdjustments { get; }
	public bool ignoreSpacingAdjustments { get; }


	public uint get_firstGlyph() { }

	public void set_firstGlyph(uint value) { }

	public GlyphValueRecord_Legacy get_firstGlyphAdjustments() { }

	public uint get_secondGlyph() { }

	public void set_secondGlyph(uint value) { }

	public GlyphValueRecord_Legacy get_secondGlyphAdjustments() { }

	public bool get_ignoreSpacingAdjustments() { }

	public void .ctor() { }

	public void .ctor(uint left, uint right, float offset) { }

	public void .ctor(uint firstGlyph, GlyphValueRecord_Legacy firstGlyphAdjustments, uint secondGlyph, GlyphValueRecord_Legacy secondGlyphAdjustments) { }

	internal void ConvertLegacyKerningData() { }

	private static void .cctor() { }

}

public class KerningTable // TypeDefIndex: 6769
{	public List<KerningPair> kerningPairs; // 0x10


	public void .ctor() { }

	public void AddKerningPair() { }

	public int AddKerningPair(uint first, uint second, float offset) { }

	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	public void RemoveKerningPair(int left, int right) { }

	public void RemoveKerningPair(int index) { }

	public void SortKerningPairs() { }

}

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6770
{	public uint first; // 0x10
	public uint second; // 0x14


	public void .ctor() { }

	internal bool <AddKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6771
{	public uint first; // 0x10
	public uint second; // 0x14


	public void .ctor() { }

	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6772
{	public int left; // 0x10
	public int right; // 0x14


	public void .ctor() { }

	internal bool <RemoveKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c // TypeDefIndex: 6773
{	public static readonly KerningTable.<>c <>9; // 0x0
	public static Func<KerningPair, uint> <>9__7_0; // 0x8
	public static Func<KerningPair, uint> <>9__7_1; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

}

