public struct Line // TypeDefIndex: 6588
{	// Fields
	public Vector3 point0; // 0x0
	public Vector3 point1; // 0xC

	// Methods

	// RVA: 0x1BD4F0 Offset: 0x1BC8F0 VA: 0x1801BD4F0
	public void .ctor(Vector3 point0, Vector3 point1) { }

	// RVA: 0x22C3B0 Offset: 0x22B7B0 VA: 0x18022C3B0
	public void .ctor(Vector3 origin, Vector3 direction, float length) { }

	// RVA: 0x22C360 Offset: 0x22B760 VA: 0x18022C360
	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	// RVA: 0x22C140 Offset: 0x22B540 VA: 0x18022C140
	public Vector3 ClosestPoint(Vector3 pos) { }

	// RVA: 0x22C100 Offset: 0x22B500 VA: 0x18022C100
	public Vector3 ClosestPoint2D(Vector3 pos) { }

	// RVA: 0x22C180 Offset: 0x22B580 VA: 0x18022C180
	public float Distance(Vector3 pos) { }

	// RVA: 0x22C270 Offset: 0x22B670 VA: 0x18022C270
	public float SqrDistance(Vector3 pos) { }

}

