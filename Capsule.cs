public struct Capsule // TypeDefIndex: 6598
{
	public Vector3 position;
	public float radius;
	public float extent;


	public void .ctor(Vector3 position, float radius, float extent) { }

	public bool Contains(Vector3 target) { }

	public Vector3 ClosestPoint(Vector3 target) { }

	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	public bool Trace(Ray ray, out RaycastHit hit, float rayRadius = 0, float maxDistance = ∞) { }

}

