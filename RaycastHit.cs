public struct RaycastHit // TypeDefIndex: 3919
{	[NativeNameAttribute] // RVA: 0x70E80 Offset: 0x70280 VA: 0x180070E80
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

	public Collider collider { get; }
	public Vector3 point { get; set; }
	public Vector3 normal { get; set; }
	public float distance { get; set; }
	public int triangleIndex { get; }
	public Vector2 textureCoord { get; }
	public Vector2 textureCoord2 { get; }
	public Transform transform { get; }
	public Rigidbody rigidbody { get; }


	public Collider get_collider() { }

	public Vector3 get_point() { }

	public void set_point(Vector3 value) { }

	public Vector3 get_normal() { }

	public void set_normal(Vector3 value) { }

	public float get_distance() { }

	public void set_distance(float value) { }

	public int get_triangleIndex() { }

	[FreeFunctionAttribute] // RVA: 0x7A1F0 Offset: 0x795F0 VA: 0x18007A1F0
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	public Vector2 get_textureCoord() { }

	public Vector2 get_textureCoord2() { }

	public Transform get_transform() { }

	public Rigidbody get_rigidbody() { }

	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

