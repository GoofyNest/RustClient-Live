public struct OBB // TypeDefIndex: 6590
{	public Quaternion rotation; // 0x0
	public Vector3 position; // 0x10
	public Vector3 extents; // 0x1C
	public Vector3 forward; // 0x28
	public Vector3 right; // 0x34
	public Vector3 up; // 0x40
	public float reject; // 0x4C


	public void .ctor(Transform transform, Bounds bounds) { }

	public void .ctor(Vector3 position, Vector3 scale, Quaternion rotation, Bounds bounds) { }

	public void .ctor(Vector3 position, Quaternion rotation, Bounds bounds) { }

	public void .ctor(Vector3 position, Vector3 size, Quaternion rotation) { }

	public void Transform(Vector3 position, Vector3 scale, Quaternion rotation) { }

	public Vector3 GetPoint(float x, float y, float z) { }

	public Bounds ToBounds() { }

	public bool Contains(Vector3 target) { }

	public bool Intersects(OBB target) { }

	public bool Intersects2D(OBB target) { }

	public bool Intersects(Ray ray) { }

	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

	public Vector3 ClosestPoint(Vector3 target) { }

	public float Distance(OBB other) { }

	public float Distance(Vector3 position) { }

	public float SqrDistance(OBB other) { }

	public float SqrDistance(Vector3 position) { }

}

