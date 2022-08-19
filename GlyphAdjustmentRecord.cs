internal struct GlyphAdjustmentRecord // TypeDefIndex: 4114
{	// Fields
	[NativeNameAttribute] // RVA: 0x88EC0 Offset: 0x882C0 VA: 0x180088EC0
	[SerializeField] // RVA: 0x88EC0 Offset: 0x882C0 VA: 0x180088EC0
	private uint m_GlyphIndex; // 0x0
	[SerializeField] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	[NativeNameAttribute] // RVA: 0x88FD0 Offset: 0x883D0 VA: 0x180088FD0
	private GlyphValueRecord m_GlyphValueRecord; // 0x4

	// Properties
	public uint glyphIndex { get; }
	public GlyphValueRecord glyphValueRecord { get; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public uint get_glyphIndex() { }

	// RVA: 0x23D980 Offset: 0x23CD80 VA: 0x18023D980
	public GlyphValueRecord get_glyphValueRecord() { }

}

