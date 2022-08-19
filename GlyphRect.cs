public struct GlyphRect : IEquatable<GlyphRect> // TypeDefIndex: 4110
{	// Fields
	[NativeNameAttribute] // RVA: 0x85880 Offset: 0x84C80 VA: 0x180085880
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

	// Properties
	public int x { get; }
	public int y { get; }
	public int width { get; }
	public int height { get; }
	public static GlyphRect zero { get; }

	// Methods

	// RVA: 0x13A500 Offset: 0x139900 VA: 0x18013A500
	public int get_x() { }

	// RVA: 0x13A260 Offset: 0x139660 VA: 0x18013A260
	public int get_y() { }

	// RVA: 0x13AB80 Offset: 0x139F80 VA: 0x18013AB80
	public int get_width() { }

	// RVA: 0x221BF0 Offset: 0x220FF0 VA: 0x180221BF0
	public int get_height() { }

	// RVA: 0x22EB930 Offset: 0x22EAD30 VA: 0x1822EB930
	public static GlyphRect get_zero() { }

	// RVA: 0x223440 Offset: 0x222840 VA: 0x180223440
	public void .ctor(int x, int y, int width, int height) { }

	// RVA: 0x23DCC0 Offset: 0x23D0C0 VA: 0x18023DCC0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x23DBC0 Offset: 0x23CFC0 VA: 0x18023DBC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23DC30 Offset: 0x23D030 VA: 0x18023DC30 Slot: 4
	public bool Equals(GlyphRect other) { }

	// RVA: 0x22EB8E0 Offset: 0x22EACE0 VA: 0x1822EB8E0
	private static void .cctor() { }

}

