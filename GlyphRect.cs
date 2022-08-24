public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{
	[NativeNameAttribute] 
	[SerializeField] 
	private int m_X; 
	[SerializeField] 
	[NativeNameAttribute] 
	private int m_Y; 
	[NativeNameAttribute] 
	[SerializeField] 
	private int m_Width; 
	[SerializeField] 
	[NativeNameAttribute] 
	private int m_Height; 
	private static readonly GlyphRect s_ZeroGlyphRect; 

	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }


	public int get_x() { }

	public int get_y() { }

	public int get_width() { }

	public int get_height() { }

	public static GlyphRect get_zero() { }

	public void .ctor(int x, int y, int width, int height) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public bool Equals(GlyphRect other) { }

	private static void .cctor() { }

}

