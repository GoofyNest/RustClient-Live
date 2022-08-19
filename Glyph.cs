public class Glyph // TypeDefIndex: 4112
{	// Fields
	[NativeNameAttribute] // RVA: 0x86530 Offset: 0x85930 VA: 0x180086530
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

	// Properties
	public uint index { get; set; }
	public GlyphMetrics metrics { get; set; }
	public GlyphRect glyphRect { get; set; }
	public float scale { get; set; }
	public int atlasIndex { get; set; }

	// Methods

	// RVA: 0x1824470 Offset: 0x1823870 VA: 0x181824470
	public uint get_index() { }

	// RVA: 0x596240 Offset: 0x595640 VA: 0x180596240
	public void set_index(uint value) { }

	// RVA: 0x22EB760 Offset: 0x22EAB60 VA: 0x1822EB760
	public GlyphMetrics get_metrics() { }

	// RVA: 0x22EBAF0 Offset: 0x22EAEF0 VA: 0x1822EBAF0
	public void set_metrics(GlyphMetrics value) { }

	// RVA: 0x1A67E60 Offset: 0x1A67260 VA: 0x181A67E60
	public GlyphRect get_glyphRect() { }

	// RVA: 0x1081470 Offset: 0x1080870 VA: 0x181081470
	public void set_glyphRect(GlyphRect value) { }

	// RVA: 0x22E92A0 Offset: 0x22E86A0 VA: 0x1822E92A0
	public float get_scale() { }

	// RVA: 0x10B2D70 Offset: 0x10B2170 VA: 0x1810B2D70
	public void set_scale(float value) { }

	// RVA: 0x22EBAE0 Offset: 0x22EAEE0 VA: 0x1822EBAE0
	public int get_atlasIndex() { }

	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	public void set_atlasIndex(int value) { }

	// RVA: 0x22EBA10 Offset: 0x22EAE10 VA: 0x1822EBA10
	public void .ctor() { }

	// RVA: 0x22EBA50 Offset: 0x22EAE50 VA: 0x1822EBA50
	internal void .ctor(GlyphMarshallingStruct glyphStruct) { }

	// RVA: 0x22EB9A0 Offset: 0x22EADA0 VA: 0x1822EB9A0
	public void .ctor(uint index, GlyphMetrics metrics, GlyphRect glyphRect, float scale, int atlasIndex) { }

}

