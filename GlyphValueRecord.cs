internal struct GlyphValueRecord // TypeDefIndex: 4113
{
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_XPlacement; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_YPlacement; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_XAdvance; 
	[NativeNameAttribute] 
	[SerializeField] 
	private float m_YAdvance; 

	public float xPlacement { get; }
	public float yPlacement { get; }
	public float xAdvance { get; }
	public float yAdvance { get; }


	public float get_xPlacement() { }

	public float get_yPlacement() { }

	public float get_xAdvance() { }

	public float get_yAdvance() { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

}

public struct GlyphValueRecord_Legacy // TypeDefIndex: 6767
{
	public float xPlacement; 
	public float yPlacement; 
	public float xAdvance; 
	public float yAdvance; 


	internal void .ctor(GlyphValueRecord valueRecord) { }

	public static GlyphValueRecord_Legacy op_Addition(GlyphValueRecord_Legacy a, GlyphValueRecord_Legacy b) { }

}

