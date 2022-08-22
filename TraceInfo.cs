public struct TraceInfo // TypeDefIndex: 9260
{	public bool valid; // 0x0
	public float distance; // 0x4
	public BaseEntity entity; // 0x8
	public Vector3 point; // 0x10
	public Vector3 normal; // 0x1C
	public Transform bone; // 0x28
	public PhysicMaterial material; // 0x30
	public uint partID; // 0x38
	public Collider collider; // 0x40


	public void UpdateHitTest(HitTest test) { }

	public uint BoneID() { }

	public uint MaterialID() { }

}

