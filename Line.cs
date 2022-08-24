public struct Line // TypeDefIndex: 6588
{
	public Vector3 point0; 
	public Vector3 point1; 


	public void .ctor(Vector3 point0, Vector3 point1) { }

	public void .ctor(Vector3 origin, Vector3 direction, float length) { }

	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	public Vector3 ClosestPoint(Vector3 pos) { }

	public Vector3 ClosestPoint2D(Vector3 pos) { }

	public float Distance(Vector3 pos) { }

	public float SqrDistance(Vector3 pos) { }

}

