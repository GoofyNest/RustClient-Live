public struct GlyphMetrics : IEquatable<GlyphMetrics> // TypeDefIndex: 4114
{
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_Width; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_Height; 
	[SerializeField] 
	[NativeNameAttribute] 
	private float m_HorizontalBearingX; 
	[SerializeField] 
	[NativeNameAttribute] 
	private float m_HorizontalBearingY; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_HorizontalAdvance; 

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

