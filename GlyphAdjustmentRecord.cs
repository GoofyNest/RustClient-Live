internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{
	[NativeNameAttribute] 
	[SerializeField] 
	private uint m_GlyphIndex; 
	[SerializeField] 
	[NativeNameAttribute] 
	private GlyphValueRecord m_GlyphValueRecord; 

public uint glyphIndex { get; }
public GlyphValueRecord glyphValueRecord { get; }


public uint get_glyphIndex() { }

public GlyphValueRecord get_glyphValueRecord() { }

}

