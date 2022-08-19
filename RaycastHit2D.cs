public struct RaycastHit2D // TypeDefIndex: 4084
{	// Fields
	[NativeNameAttribute] // RVA: 0x71DE0 Offset: 0x711E0 VA: 0x180071DE0
	private Vector2 m_Centroid; // 0x0
	[NativeNameAttribute] // RVA: 0x70E80 Offset: 0x70280 VA: 0x180070E80
	private Vector2 m_Point; // 0x8
	[NativeNameAttribute] // RVA: 0x70F90 Offset: 0x70390 VA: 0x180070F90
	private Vector2 m_Normal; // 0x10
	[NativeNameAttribute] // RVA: 0x721D0 Offset: 0x715D0 VA: 0x1800721D0
	private float m_Distance; // 0x18
	[NativeNameAttribute] // RVA: 0x72350 Offset: 0x71750 VA: 0x180072350
	private float m_Fraction; // 0x1C
	[NativeNameAttribute] // RVA: 0x715F0 Offset: 0x709F0 VA: 0x1800715F0
	private int m_Collider; // 0x20

	// Properties
	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }

	// Methods

	// RVA: 0x240410 Offset: 0x23F810 VA: 0x180240410
	public Vector2 get_point() { }

	// RVA: 0x11FBE0 Offset: 0x11EFE0 VA: 0x18011FBE0
	public Vector2 get_normal() { }

	// RVA: 0x23D6E0 Offset: 0x23CAE0 VA: 0x18023D6E0
	public float get_distance() { }

	// RVA: 0x240360 Offset: 0x23F760 VA: 0x180240360
	public Collider2D get_collider() { }

}

