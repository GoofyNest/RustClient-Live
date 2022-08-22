public struct RaycastHit2D // TypeDefIndex: 4084
{	[NativeNameAttribute] // RVA: 0x71DE0 Offset: 0x711E0 VA: 0x180071DE0
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

	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }


	public Vector2 get_point() { }

	public Vector2 get_normal() { }

	public float get_distance() { }

	public Collider2D get_collider() { }

}

