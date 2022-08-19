public struct OBB // TypeDefIndex: 6590
{	// Fields
	public Quaternion rotation; // 0x0
	public Vector3 position; // 0x10
	public Vector3 extents; // 0x1C
	public Vector3 forward; // 0x28
	public Vector3 right; // 0x34
	public Vector3 up; // 0x40
	public float reject; // 0x4C

	// Methods

	// RVA: 0x22D5D0 Offset: 0x22C9D0 VA: 0x18022D5D0
	public void .ctor(Transform transform, Bounds bounds) { }

	// RVA: 0x22D130 Offset: 0x22C530 VA: 0x18022D130
	public void .ctor(Vector3 position, Vector3 scale, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D1C0 Offset: 0x22C5C0 VA: 0x18022D1C0
	public void .ctor(Vector3 position, Quaternion rotation, Bounds bounds) { }

	// RVA: 0x22D400 Offset: 0x22C800 VA: 0x18022D400
	public void .ctor(Vector3 position, Vector3 size, Quaternion rotation) { }

	// RVA: 0x22CF70 Offset: 0x22C370 VA: 0x18022CF70
	public void Transform(Vector3 position, Vector3 scale, Quaternion rotation) { }

	// RVA: 0x22C770 Offset: 0x22BB70 VA: 0x18022C770
	public Vector3 GetPoint(float x, float y, float z) { }

	// RVA: 0x22CF10 Offset: 0x22C310 VA: 0x18022CF10
	public Bounds ToBounds() { }

	// RVA: 0x22C4E0 Offset: 0x22B8E0 VA: 0x18022C4E0
	public bool Contains(Vector3 target) { }

	// RVA: 0x22CB00 Offset: 0x22BF00 VA: 0x18022CB00
	public bool Intersects(OBB target) { }

	// RVA: 0x22C960 Offset: 0x22BD60 VA: 0x18022C960
	public bool Intersects2D(OBB target) { }

	// RVA: 0x22CC00 Offset: 0x22C000 VA: 0x18022CC00
	public bool Intersects(Ray ray) { }

	// RVA: 0x22CF30 Offset: 0x22C330 VA: 0x18022CF30
	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C4A0 Offset: 0x22B8A0 VA: 0x18022C4A0
	public Vector3 ClosestPoint(Vector3 target) { }

	// RVA: 0x22C510 Offset: 0x22B910 VA: 0x18022C510
	public float Distance(OBB other) { }

	// RVA: 0x22C6B0 Offset: 0x22BAB0 VA: 0x18022C6B0
	public float Distance(Vector3 position) { }

	// RVA: 0x22CD50 Offset: 0x22C150 VA: 0x18022CD50
	public float SqrDistance(OBB other) { }

	// RVA: 0x22CC60 Offset: 0x22C060 VA: 0x18022CC60
	public float SqrDistance(Vector3 position) { }

}

