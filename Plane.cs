public struct Plane // TypeDefIndex: 3374
{	// Fields
	internal const int size = 16;
	private Vector3 m_Normal; // 0x0
	private float m_Distance; // 0xC

	// Properties
	public Vector3 normal { get; set; }
	public float distance { get; set; }

	// Methods

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_normal() { }

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_normal(Vector3 value) { }

	// RVA: 0x2121E0 Offset: 0x2115E0 VA: 0x1802121E0
	public float get_distance() { }

	// RVA: 0x116F90 Offset: 0x116390 VA: 0x180116F90
	public void set_distance(float value) { }

	// RVA: 0x216E70 Offset: 0x216270 VA: 0x180216E70
	public void .ctor(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x216D80 Offset: 0x216180 VA: 0x180216D80
	public void SetNormalAndPosition(Vector3 inNormal, Vector3 inPoint) { }

	// RVA: 0x2169C0 Offset: 0x215DC0 VA: 0x1802169C0
	public Vector3 ClosestPointOnPlane(Vector3 point) { }

	// RVA: 0x216AF0 Offset: 0x215EF0 VA: 0x180216AF0
	public bool GetSide(Vector3 point) { }

	// RVA: 0x216BA0 Offset: 0x215FA0 VA: 0x180216BA0
	public bool Raycast(Ray ray, out float enter) { }

	// RVA: 0x216E60 Offset: 0x216260 VA: 0x180216E60 Slot: 3
	public override string ToString() { }

}

