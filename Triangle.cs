public struct Triangle // TypeDefIndex: 6599
{
	public Vector3 point0; 
	public Vector3 point1; 
	public Vector3 point2; 

	public Vector3 Normal { get; }
	public Vector3 Center { get; }


	public void .ctor(Vector3 point0, Vector3 point1, Vector3 point2) { }

	public bool Trace(Ray ray, float radius, out RaycastHit hit, float maxDistance = ∞) { }

	private bool LineTest(Vector3 a, Vector3 b, Ray ray, float radius, out RaycastHit hit, float maxDistance) { }

	public Vector3 get_Normal() { }

	public Vector3 get_Center() { }

	public Vector3 ClosestPoint(Vector3 pos) { }

	public float Distance(Vector3 pos) { }

	public float SqrDistance(Vector3 pos) { }

}

