public struct RaycastHit // TypeDefIndex: 3919
{	// Fields
	[NativeNameAttribute] // RVA: 0x70E80 Offset: 0x70280 VA: 0x180070E80
	internal Vector3 m_Point; // 0x0
	[NativeNameAttribute] // RVA: 0x70F90 Offset: 0x70390 VA: 0x180070F90
	internal Vector3 m_Normal; // 0xC
	[NativeNameAttribute] // RVA: 0x8D520 Offset: 0x8C920 VA: 0x18008D520
	internal uint m_FaceID; // 0x18
	[NativeNameAttribute] // RVA: 0x721D0 Offset: 0x715D0 VA: 0x1800721D0
	internal float m_Distance; // 0x1C
	[NativeNameAttribute] // RVA: 0x8D820 Offset: 0x8CC20 VA: 0x18008D820
	internal Vector2 m_UV; // 0x20
	[NativeNameAttribute] // RVA: 0x715F0 Offset: 0x709F0 VA: 0x1800715F0
	internal int m_Collider; // 0x28

	// Properties
	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }

	// Methods

	// RVA: 0x239450 Offset: 0x238850 VA: 0x180239450
	public Collider get_collider() { }

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_point() { }

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_point(Vector3 value) { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public Vector3 get_normal() { }

	// RVA: 0x212B50 Offset: 0x211F50 VA: 0x180212B50
	public void set_normal(Vector3 value) { }

	// RVA: 0x239460 Offset: 0x238860 VA: 0x180239460
	public float get_distance() { }

	// RVA: 0x2396C0 Offset: 0x238AC0 VA: 0x1802396C0
	public void set_distance(float value) { }

	// RVA: 0x2121A0 Offset: 0x2115A0 VA: 0x1802121A0
	public int get_triangleIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	// RVA: 0x2298AA0 Offset: 0x2297EA0 VA: 0x182298AA0
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	// RVA: 0x239520 Offset: 0x238920 VA: 0x180239520
	public Vector2 get_textureCoord() { }

	// RVA: 0x239480 Offset: 0x238880 VA: 0x180239480
	public Vector2 get_textureCoord2() { }

	// RVA: 0x2395C0 Offset: 0x2389C0 VA: 0x1802395C0
	public Transform get_transform() { }

	// RVA: 0x239470 Offset: 0x238870 VA: 0x180239470
	public Rigidbody get_rigidbody() { }

	// RVA: 0x2298A30 Offset: 0x2297E30 VA: 0x182298A30
	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

