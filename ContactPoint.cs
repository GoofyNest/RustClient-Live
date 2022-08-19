public struct ContactPoint // TypeDefIndex: 3932
{	// Fields
	internal Vector3 m_Point; // 0x0
	internal Vector3 m_Normal; // 0xC
	internal int m_ThisColliderInstanceID; // 0x18
	internal int m_OtherColliderInstanceID; // 0x1C
	internal float m_Separation; // 0x20

	// Properties
	public Vector3 point { get; }
	public Vector3 normal { get; }

	// Methods

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_point() { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public Vector3 get_normal() { }

}

