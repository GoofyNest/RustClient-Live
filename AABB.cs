public struct AABB // TypeDefIndex: 6585
{	public Vector3 position; // 0x0
	public Vector3 extents; // 0xC


	public void .ctor(Vector3 position, Vector3 size) { }

	public bool Contains(Vector3 target) { }

	public Vector3 ClosestPoint(Vector3 target) { }

	public bool Trace(Ray ray, out RaycastHit hit, float radius = 0, float maxDistance = ∞) { }

}

