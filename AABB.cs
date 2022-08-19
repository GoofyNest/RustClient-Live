public struct AABB // TypeDefIndex: 6585
{	// Fields
	public Vector3 position; // 0x0
	public Vector3 extents; // 0xC

	// Methods

	// RVA: 0x22BC40 Offset: 0x22B040 VA: 0x18022BC40
	public void .ctor(Vector3 position, Vector3 size) { }

	// RVA: 0x22BA70 Offset: 0x22AE70 VA: 0x18022BA70
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BA30 Offset: 0x22AE30 VA: 0x18022BA30
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BBF0 Offset: 0x22AFF0 VA: 0x18022BBF0
	public bool Trace(Ray ray, out RaycastHit hit, float radius = 0, float maxDistance = ∞) { }

}

