public struct ContactPoint // TypeDefIndex: 3937
{
	internal Vector3 m_Point;
	internal Vector3 m_Normal;
	internal int m_ThisColliderInstanceID;
	internal int m_OtherColliderInstanceID;
	internal float m_Separation;

	public Vector3 point { get; }
	public Vector3 normal { get; }


	public Vector3 get_point() { }

	public Vector3 get_normal() { }

}

