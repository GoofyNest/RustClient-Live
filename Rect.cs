public struct Rect : IEquatable<Rect> // TypeDefIndex: 3376
{	[NativeNameAttribute] // RVA: 0x7F530 Offset: 0x7E930 VA: 0x18007F530
	private float m_XMin; // 0x0
	[NativeNameAttribute] // RVA: 0x7F640 Offset: 0x7EA40 VA: 0x18007F640
	private float m_YMin; // 0x4
	[NativeNameAttribute] // RVA: 0x7F6F0 Offset: 0x7EAF0 VA: 0x18007F6F0
	private float m_Width; // 0x8
	[NativeNameAttribute] // RVA: 0x7F820 Offset: 0x7EC20 VA: 0x18007F820
	private float m_Height; // 0xC

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


	public void .ctor(float x, float y, float width, float height) { }

	public void .ctor(Vector2 position, Vector2 size) { }

	public void .ctor(Rect source) { }

	public static Rect get_zero() { }

	public static Rect MinMaxRect(float xmin, float ymin, float xmax, float ymax) { }

	public float get_x() { }

	public void set_x(float value) { }

	public float get_y() { }

	public void set_y(float value) { }

	public Vector2 get_position() { }

	public void set_position(Vector2 value) { }

	public Vector2 get_center() { }

	public void set_center(Vector2 value) { }

	public Vector2 get_min() { }

	public void set_min(Vector2 value) { }

	public Vector2 get_max() { }

	public void set_max(Vector2 value) { }

	public float get_width() { }

	public void set_width(float value) { }

	public float get_height() { }

	public void set_height(float value) { }

	public Vector2 get_size() { }

	public void set_size(Vector2 value) { }

	public float get_xMin() { }

	public void set_xMin(float value) { }

	public float get_yMin() { }

	public void set_yMin(float value) { }

	public float get_xMax() { }

	public void set_xMax(float value) { }

	public float get_yMax() { }

	public void set_yMax(float value) { }

	public bool Contains(Vector2 point) { }

	public bool Contains(Vector3 point) { }

	private static Rect OrderMinMax(Rect rect) { }

	public bool Overlaps(Rect other) { }

	public bool Overlaps(Rect other, bool allowInverse) { }

	public static bool op_Inequality(Rect lhs, Rect rhs) { }

	public static bool op_Equality(Rect lhs, Rect rhs) { }

	public override int GetHashCode() { }

	public override bool Equals(object other) { }

	public bool Equals(Rect other) { }

	public override string ToString() { }

}

