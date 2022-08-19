public struct Ray // TypeDefIndex: 3375
{	// Fields
	private Vector3 m_Origin; // 0x0
	private Vector3 m_Direction; // 0xC

	// Properties
	public Vector3 origin { get; set; }
	public Vector3 direction { get; set; }

	// Methods

	// RVA: 0x217C20 Offset: 0x217020 VA: 0x180217C20
	public void .ctor(Vector3 origin, Vector3 direction) { }

	// RVA: 0x212A20 Offset: 0x211E20 VA: 0x180212A20
	public Vector3 get_origin() { }

	// RVA: 0x204DC0 Offset: 0x2041C0 VA: 0x180204DC0
	public void set_origin(Vector3 value) { }

	// RVA: 0x212A40 Offset: 0x211E40 VA: 0x180212A40
	public Vector3 get_direction() { }

	// RVA: 0x217C80 Offset: 0x217080 VA: 0x180217C80
	public void set_direction(Vector3 value) { }

	// RVA: 0x2179A0 Offset: 0x216DA0 VA: 0x1802179A0
	public Vector3 GetPoint(float distance) { }

	// RVA: 0x217AB0 Offset: 0x216EB0 VA: 0x180217AB0 Slot: 3
	public override string ToString() { }

}

