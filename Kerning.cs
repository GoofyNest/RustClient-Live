public struct KerningPairKey // TypeDefIndex: 6710
{
	public uint ascii_Left;
	public uint ascii_Right;
	public uint key;


	public void .ctor(uint ascii_left, uint ascii_right) { }

}

public class KerningPair // TypeDefIndex: 6712
{
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private uint m_FirstGlyph;
	[SerializeField]
	private GlyphValueRecord_Legacy m_FirstGlyphAdjustments;
	[FormerlySerializedAsAttribute]
	[SerializeField]
	private uint m_SecondGlyph;
	[SerializeField]
	private GlyphValueRecord_Legacy m_SecondGlyphAdjustments;
	[FormerlySerializedAsAttribute]
	public float xOffset;
	internal static KerningPair empty;
	[SerializeField]
	private bool m_IgnoreSpacingAdjustments;

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

public class KerningTable // TypeDefIndex: 6713
{
	public List<KerningPair> kerningPairs;


	public void .ctor() { }

	public void AddKerningPair() { }

	public int AddKerningPair(uint first, uint second, float offset) { }

	public int AddGlyphPairAdjustmentRecord(uint first, GlyphValueRecord_Legacy firstAdjustments, uint second, GlyphValueRecord_Legacy secondAdjustments) { }

	public void RemoveKerningPair(int left, int right) { }

	public void RemoveKerningPair(int index) { }

	public void SortKerningPairs() { }

}

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6714
{
	public uint first;
	public uint second;


	public void .ctor() { }

	internal bool <AddKerningPair>

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6715
{
	public uint first;
	public uint second;


	public void .ctor() { }

	internal bool <AddGlyphPairAdjustmentRecord>

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6716
{
	public int left;
	public int right;


	public void .ctor() { }

	internal bool <RemoveKerningPair>

}

private sealed class KerningTable.<>c // TypeDefIndex: 6717
{
	public static readonly KerningTable.<>c <>9;
	public static Func<KerningPair, uint> <>9__7_0;
	public static Func<KerningPair, uint> <>9__7_1;


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortKerningPairs>

	internal uint <SortKerningPairs>

}

