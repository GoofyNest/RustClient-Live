public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	// Fields
	[NativeNameAttribute] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	[SerializeField] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	private float m_Width; // 0x0
	[NativeNameAttribute] // RVA: 0x85E60 Offset: 0x85260 VA: 0x180085E60
	[SerializeField] // RVA: 0x85E60 Offset: 0x85260 VA: 0x180085E60
	private float m_Height; // 0x4
	[SerializeField] // RVA: 0x86040 Offset: 0x85440 VA: 0x180086040
	[NativeNameAttribute] // RVA: 0x86040 Offset: 0x85440 VA: 0x180086040
	private float m_HorizontalBearingX; // 0x8
	[SerializeField] // RVA: 0x86120 Offset: 0x85520 VA: 0x180086120
	[NativeNameAttribute] // RVA: 0x86120 Offset: 0x85520 VA: 0x180086120
	private float m_HorizontalBearingY; // 0xC
	[NativeNameAttribute] // RVA: 0x862D0 Offset: 0x856D0 VA: 0x1800862D0
	[SerializeField] // RVA: 0x862D0 Offset: 0x856D0 VA: 0x1800862D0
	private float m_HorizontalAdvance; // 0x10

	// Properties
	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }

	// Methods

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_width() { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_height() { }

	// RVA: 0x2121D0 Offset: 0x2115D0 VA: 0x1802121D0
	public float get_horizontalBearingX() { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0
	public float get_horizontalBearingY() { }

	// RVA: 0x23DB70 Offset: 0x23CF70 VA: 0x18023DB70
	public float get_horizontalAdvance() { }

	// RVA: 0x23DB40 Offset: 0x23CF40 VA: 0x18023DB40
	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	// RVA: 0x23DAE0 Offset: 0x23CEE0 VA: 0x18023DAE0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DA70 Offset: 0x23CE70 VA: 0x18023DA70 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23D9D0 Offset: 0x23CDD0 VA: 0x18023D9D0 Slot: 4
	public bool Equals(GlyphMetrics other) { }

}

