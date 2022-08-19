public struct Sphere // TypeDefIndex: 6593
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC

	// Methods

	// RVA: 0xFBB90 Offset: 0xFAF90 VA: 0x1800FBB90
	public void .ctor(Vector3 position, float radius) { }

	// RVA: 0x22D720 Offset: 0x22CB20 VA: 0x18022D720
	public bool Contains(Vector3 target) { }

	// RVA: 0x22D6E0 Offset: 0x22CAE0 VA: 0x18022D6E0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22D7E0 Offset: 0x22CBE0 VA: 0x18022D7E0
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22D9B0 Offset: 0x22CDB0 VA: 0x18022D9B0
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

}

