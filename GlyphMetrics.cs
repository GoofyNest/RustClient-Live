public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4111
{	[NativeNameAttribute] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
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

	public float width { get; }
	public float height { get; }
	public float horizontalBearingX { get; }
	public float horizontalBearingY { get; }
	public float horizontalAdvance { get; }


	public float get_width() { }

	public float get_height() { }

	public float get_horizontalBearingX() { }

	public float get_horizontalBearingY() { }

	public float get_horizontalAdvance() { }

	public void .ctor(float width, float height, float bearingX, float bearingY, float advance) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(GlyphMetrics other) { }

}

