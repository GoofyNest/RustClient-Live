public struct ContactPoint // TypeDefIndex: 3932
{	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal int m_ThisColliderInstanceID; // 0x18
	internal int m_OtherColliderInstanceID; // 0x1C
	internal float m_Separation; // 0x20

	public Vector3 point { get; }
	public Vector3 normal { get; }


	public Vector3 get_point() { }

	public Vector3 get_normal() { }

}

