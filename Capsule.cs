public struct Capsule // TypeDefIndex: 6586
{	// Fields
	public Vector3 position; // 0x0
	public float radius; // 0xC
	public float extent; // 0x10

	// Methods

	// RVA: 0x22BE80 Offset: 0x22B280 VA: 0x18022BE80
	public void .ctor(Vector3 position, float radius, float extent) { }

	// RVA: 0x22BD30 Offset: 0x22B130 VA: 0x18022BD30
	public bool Contains(Vector3 target) { }

	// RVA: 0x22BCF0 Offset: 0x22B0F0 VA: 0x18022BCF0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22BDF0 Offset: 0x22B1F0 VA: 0x18022BDF0
	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	// RVA: 0x22BE30 Offset: 0x22B230 VA: 0x18022BE30
	public bool Trace(Ray ray, out RaycastHit hit, float rayRadius = 0, float maxDistance = ∞) { }

}

