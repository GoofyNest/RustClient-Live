public class WorldSpline : MonoBehaviour // TypeDefIndex: 13146
{
	public int dataIndex; 
	public Vector3[] points; 
	public Vector3[] tangents; 
	[RangeAttribute] 
	public float lutInterval; 
	[SerializeField] 
	private bool showGizmos; 
	private static List<Vector3> visualSplineList; 
	private WorldSplineData privateData; 


	public WorldSplineData GetData() { }

	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	public void CheckValidity() { }

	protected virtual void OnDrawGizmosSelected() { }

	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	public Vector3 GetStartPointWorld() { }

	public Vector3 GetEndPointWorld() { }

	public Vector3 GetStartTangentWorld() { }

	public Vector3 GetEndTangentWorld() { }

	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	public Vector3[] GetPointsWorld() { }

	public Vector3[] GetTangentsWorld() { }

	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	public void .ctor() { }

	private static void .cctor() { }

}

