public class Glyph // TypeDefIndex: 4112
{	[NativeNameAttribute] // RVA: 0x86530 Offset: 0x85930 VA: 0x180086530
	[SerializeField] // RVA: 0x86530 Offset: 0x85930 VA: 0x180086530
	private uint m_Index; // 0x10
	[SerializeField] // RVA: 0x87A40 Offset: 0x86E40 VA: 0x180087A40
	[NativeNameAttribute] // RVA: 0x87A40 Offset: 0x86E40 VA: 0x180087A40
	private GlyphMetrics m_Metrics; // 0x14
	[SerializeField] // RVA: 0x87CA0 Offset: 0x870A0 VA: 0x180087CA0
	[NativeNameAttribute] // RVA: 0x87CA0 Offset: 0x870A0 VA: 0x180087CA0
	private GlyphRect m_GlyphRect; // 0x28
	[NativeNameAttribute] // RVA: 0x87F70 Offset: 0x87370 VA: 0x180087F70
	[SerializeField] // RVA: 0x87F70 Offset: 0x87370 VA: 0x180087F70
	private float m_Scale; // 0x38
	[NativeNameAttribute] // RVA: 0x880C0 Offset: 0x874C0 VA: 0x1800880C0
	[SerializeField] // RVA: 0x880C0 Offset: 0x874C0 VA: 0x1800880C0
	private int m_AtlasIndex; // 0x3C

	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }


	public uint get_index() { }

	public void set_index(uint value) { }

	public GlyphMetrics get_metrics() { }

	public void set_metrics(GlyphMetrics value) { }

	public GlyphRect get_glyphRect() { }

	public void set_glyphRect(GlyphRect value) { }

	public float get_scale() { }

	public void set_scale(float value) { }

	public int get_atlasIndex() { }

	public void set_atlasIndex(int value) { }

	public void .ctor() { }

	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

