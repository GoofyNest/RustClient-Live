public struct Rect : IEquatable<Rect> // TypeDefIndex: 3376
{	// Fields
	[NativeNameAttribute] // RVA: 0x7F530 Offset: 0x7E930 VA: 0x18007F530
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0x7F640 Offset: 0x7EA40 VA: 0x18007F640
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0x7F6F0 Offset: 0x7EAF0 VA: 0x18007F6F0
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x7F820 Offset: 0x7EC20 VA: 0x18007F820
	private float m_Height; // 0xC

	// Properties
	public static Rect zero { get; }
	public float x { get; set; }
	public float y { get; set; }
	public Vector2 position { get; set; }
	public Vector2 center { get; set; }
	public Vector2 min { get; set; }
	public Vector2 max { get; set; }
	public float width { get; set; }
	public float height { get; set; }
	public Vector2 size { get; set; }
	public float xMin { get; set; }
	public float yMin { get; set; }
	public float xMax { get; set; }
	public float yMax { get; set; }

	// Methods

	// RVA: 0xF2CA0 Offset: 0xF20A0 VA: 0x1800F2CA0
	public void .ctor(float x, float y, float width, float height) { }

	// RVA: 0x2181A0 Offset: 0x2175A0 VA: 0x1802181A0
	public void .ctor(Vector2 position, Vector2 size) { }

	// RVA: 0x117720 Offset: 0x116B20 VA: 0x180117720
	public void .ctor(Rect source) { }

	// RVA: 0x181F4C0 Offset: 0x181E8C0 VA: 0x18181F4C0
	public static Rect get_zero() { }

	// RVA: 0x18FB4F0 Offset: 0x18FA8F0 VA: 0x1818FB4F0
	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_x() { }

	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280
	public void set_x(float value) { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_y() { }

	// RVA: 0x117760 Offset: 0x116B60 VA: 0x180117760
	public void set_y(float value) { }

	// RVA: 0x218270 Offset: 0x217670 VA: 0x180218270
	public Vector2 get_position() { }

	// RVA: 0x2049C0 Offset: 0x203DC0 VA: 0x1802049C0
	public void set_position(Vector2 value) { }

	// RVA: 0x2181E0 Offset: 0x2175E0 VA: 0x1802181E0
	public Vector2 get_center() { }

	// RVA: 0x2182F0 Offset: 0x2176F0 VA: 0x1802182F0
	public void set_center(Vector2 value) { }

	// RVA: 0x218270 Offset: 0x217670 VA: 0x180218270
	public Vector2 get_min() { }

	// RVA: 0x218360 Offset: 0x217760 VA: 0x180218360
	public void set_min(Vector2 value) { }

	// RVA: 0x218230 Offset: 0x217630 VA: 0x180218230
	public Vector2 get_max() { }

	// RVA: 0x218330 Offset: 0x217730 VA: 0x180218330
	public void set_max(Vector2 value) { }

	// RVA: 0x2121D0 Offset: 0x2115D0 VA: 0x1802121D0
	public float get_width() { }

	// RVA: 0x116F80 Offset: 0x116380 VA: 0x180116F80
	public void set_width(float value) { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0
	public float get_height() { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_height(float value) { }

	// RVA: 0x2182A0 Offset: 0x2176A0 VA: 0x1802182A0
	public Vector2 get_size() { }

	// RVA: 0x2183B0 Offset: 0x2177B0 VA: 0x1802183B0
	public void set_size(Vector2 value) { }

	// RVA: 0x13A270 Offset: 0x139670 VA: 0x18013A270
	public float get_xMin() { }

	// RVA: 0x2183E0 Offset: 0x2177E0 VA: 0x1802183E0
	public void set_xMin(float value) { }

	// RVA: 0x2121C0 Offset: 0x2115C0 VA: 0x1802121C0
	public float get_yMin() { }

	// RVA: 0x218410 Offset: 0x217810 VA: 0x180218410
	public void set_yMin(float value) { }

	// RVA: 0x2182D0 Offset: 0x2176D0 VA: 0x1802182D0
	public float get_xMax() { }

	// RVA: 0x2183D0 Offset: 0x2177D0 VA: 0x1802183D0
	public void set_xMax(float value) { }

	// RVA: 0x2182E0 Offset: 0x2176E0 VA: 0x1802182E0
	public float get_yMax() { }

	// RVA: 0x218400 Offset: 0x217800 VA: 0x180218400
	public void set_yMax(float value) { }

	// RVA: 0x217D20 Offset: 0x217120 VA: 0x180217D20
	public bool Contains(Vector2 point) { }

	// RVA: 0x217CD0 Offset: 0x2170D0 VA: 0x180217CD0
	public bool Contains(Vector3 point) { }

	// RVA: 0x18FB520 Offset: 0x18FA920 VA: 0x1818FB520
	private static Rect OrderMinMax(Rect rect) { }

	// RVA: 0x217FB0 Offset: 0x2173B0 VA: 0x180217FB0
	public bool Overlaps(Rect other) { }

	// RVA: 0x218010 Offset: 0x217410 VA: 0x180218010
	public bool Overlaps(Rect other, bool allowInverse) { }

	// RVA: 0x18FBAE0 Offset: 0x18FAEE0 VA: 0x1818FBAE0
	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	// RVA: 0x18FBAA0 Offset: 0x18FAEA0 VA: 0x1818FBAA0
	public static bool op_Equality(Rect lhs, Rect rhs) { }

	// RVA: 0x217F10 Offset: 0x217310 VA: 0x180217F10 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x217D60 Offset: 0x217160 VA: 0x180217D60 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0x217E70 Offset: 0x217270 VA: 0x180217E70 Slot: 4
	public bool Equals(Rect other) { }

	// RVA: 0x218190 Offset: 0x217590 VA: 0x180218190 Slot: 3
	public override string ToString() { }

}

