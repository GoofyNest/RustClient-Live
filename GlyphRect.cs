public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	[NativeNameAttribute] // RVA: 0x85880 Offset: 0x84C80 VA: 0x180085880
	[SerializeField] // RVA: 0x85880 Offset: 0x84C80 VA: 0x180085880
	private int m_X; // 0x0
	[SerializeField] // RVA: 0x859D0 Offset: 0x84DD0 VA: 0x1800859D0
	[NativeNameAttribute] // RVA: 0x859D0 Offset: 0x84DD0 VA: 0x1800859D0
	private int m_Y; // 0x4
	[NativeNameAttribute] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	[SerializeField] // RVA: 0x85AC0 Offset: 0x84EC0 VA: 0x180085AC0
	private int m_Width; // 0x8
	[SerializeField] // RVA: 0x85BF0 Offset: 0x84FF0 VA: 0x180085BF0
	[NativeNameAttribute] // RVA: 0x85BF0 Offset: 0x84FF0 VA: 0x180085BF0
	private int m_Height; // 0xC
	private static readonly GlyphRect s_ZeroGlyphRect; // 0x0

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

