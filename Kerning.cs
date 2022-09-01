public struct KerningPairKey // TypeDefIndex: 6767
{
	public uint ascii_Left; 
	public uint ascii_Right; 
	public uint key; 


	public void .ctor(uint ascii_left, uint ascii_right) { }

}

public class KerningPair // TypeDefIndex: 6769
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

public class KerningTable // TypeDefIndex: 6770
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

private sealed class KerningTable.<>c__DisplayClass3_0 // TypeDefIndex: 6771
{
	public uint first; 
	public uint second; 


	public void .ctor() { }

	internal bool <AddKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass4_0 // TypeDefIndex: 6772
{
	public uint first; 
	public uint second; 


	public void .ctor() { }

	internal bool <AddGlyphPairAdjustmentRecord>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c__DisplayClass5_0 // TypeDefIndex: 6773
{
	public int left; 
	public int right; 


	public void .ctor() { }

	internal bool <RemoveKerningPair>b__0(KerningPair item) { }

}

private sealed class KerningTable.<>c // TypeDefIndex: 6774
{
	public static readonly KerningTable.<>c <>9; 
	public static Func<KerningPair, uint> <>9__7_0; 
	public static Func<KerningPair, uint> <>9__7_1; 


	private static void .cctor() { }

	public void .ctor() { }

	internal uint <SortKerningPairs>b__7_0(KerningPair s) { }

	internal uint <SortKerningPairs>b__7_1(KerningPair s) { }

}

