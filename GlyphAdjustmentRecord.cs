internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	[NativeNameAttribute] // RVA: 0x88EC0 Offset: 0x882C0 VA: 0x180088EC0
	[SerializeField] // RVA: 0x88EC0 Offset: 0x882C0 VA: 0x180088EC0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	[NativeNameAttribute] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }


	public uint get_glyphIndex() { }

	public GlyphValueRecord get_glyphValueRecord() { }

}

