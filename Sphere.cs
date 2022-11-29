public struct Sphere // TypeDefIndex: 6603
{
	public Vector3 position; 
	public float radius; 


	public void .ctor(Vector3 position, float radius) { }

	public bool Contains(Vector3 target) { }

	public Vector3 ClosestPoint(Vector3 target) { }

	public void Move(Vector3 direction, float distance, int layerMask = 0) { }

	public bool Trace(Ray ray, out RaycastHit hit, float maxDistance = ∞) { }

}

