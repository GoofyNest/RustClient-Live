public class Glyph // TypeDefIndex: 4112
{
	[NativeNameAttribute] 
	[SerializeField] 
	private uint m_Index; 
	[SerializeField] 
	[NativeNameAttribute] 
	private GlyphMetrics m_Metrics; 
	[SerializeField] 
	[NativeNameAttribute] 
	private GlyphRect m_GlyphRect; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_Scale; 
	[NativeNameAttribute] 
	[SerializeField] 
	private int m_AtlasIndex; 

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

