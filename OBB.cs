public struct OBB // TypeDefIndex: 6600
{
	public Quaternion rotation; 
	public Vector3 position; 
	public Vector3 extents; 
	public Vector3 forward; 
	public Vector3 right; 
	public Vector3 up; 
	public float reject; 


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

	public void DebugDraw(Color colour, float duration) { }

}

