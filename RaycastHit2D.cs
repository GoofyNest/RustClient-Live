public struct RaycastHit2D // TypeDefIndex: 4089
{
	[NativeNameAttribute]
	private Vector2 m_Centroid;
	[NativeNameAttribute]
	private Vector2 m_Point;
	[NativeNameAttribute]
	private Vector2 m_Normal;
	[NativeNameAttribute]
	private float m_Distance;
	[NativeNameAttribute]
	private float m_Fraction;
	[NativeNameAttribute]
	private int m_Collider;

	public Vector2 point { get; }
	public Vector2 normal { get; }
	public float distance { get; }
	public Collider2D collider { get; }


	public Vector2 get_point() { }

	public Vector2 get_normal() { }

	public float get_distance() { }

	public Collider2D get_collider() { }

}

