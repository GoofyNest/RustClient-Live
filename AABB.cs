public struct AABB // TypeDefIndex: 6595
{
	public Vector3 position; 
	public Vector3 extents; 


	public void .ctor(Vector3 position, Vector3 size) { }

	public bool Contains(Vector3 target) { }

	public Vector3 ClosestPoint(Vector3 target) { }

	public bool Trace(Ray ray, out RaycastHit hit, float radius = 0, float maxDistance = ∞) { }

}

