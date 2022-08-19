public struct TraceInfo // TypeDefIndex: 9260
{	// Fields
	public bool valid; // 0x0
	public float distance; // 0x4
	public BaseEntity entity; // 0x8
	public Vector3 point; // 0x10
	public Vector3 normal; // 0x1C
	public Transform bone; // 0x28
	public PhysicMaterial material; // 0x30
	public uint partID; // 0x38
	public Collider collider; // 0x40

	// Methods

	// RVA: 0xFAEA0 Offset: 0xFA2A0 VA: 0x1800FAEA0
	public void UpdateHitTest(HitTest test) { }

	// RVA: 0xFAD10 Offset: 0xFA110 VA: 0x1800FAD10
	public uint BoneID() { }

	// RVA: 0xFADD0 Offset: 0xFA1D0 VA: 0x1800FADD0
	public uint MaterialID() { }

}

