public struct RaycastHit // TypeDefIndex: 3922
{
	[NativeNameAttribute] 
	internal Vector3 m_Point; 
	[NativeNameAttribute] 
	internal Vector3 m_Normal; 
	[NativeNameAttribute] 
	internal uint m_FaceID; 
	[NativeNameAttribute] 
	internal float m_Distance; 
	[NativeNameAttribute] 
	internal Vector2 m_UV; 
	[NativeNameAttribute] 
	internal int m_Collider; 

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

	[FreeFunctionAttribute] 
	private static Vector2 CalculateRaycastTexCoord(Collider collider, Vector2 uv, Vector3 pos, uint face, int textcoord) { }

	public Vector2 get_textureCoord() { }

	public Vector2 get_textureCoord2() { }

	public Transform get_transform() { }

	public Rigidbody get_rigidbody() { }

	private static void CalculateRaycastTexCoord_Injected(Collider collider, ref Vector2 uv, ref Vector3 pos, uint face, int textcoord, out Vector2 ret) { }

}

