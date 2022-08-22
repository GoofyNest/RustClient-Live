public class WorldSpline : MonoBehaviour // TypeDefIndex: 11407
{	public int dataIndex; // 0x18
	public Vector3[] points; // 0x20
	public Vector3[] tangents; // 0x28
	[RangeAttribute] // RVA: 0xAC130 Offset: 0xAB530 VA: 0x1800AC130
	public float lutInterval; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool showGizmos; // 0x34
	private static List<Vector3> visualSplineList; // 0x0
	private WorldSplineData privateData; // 0x38


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

	public Vector3 GetTangentWorld(float distance) { }

	public Vector3 GetTangentWorld(float distance, WorldSplineData data) { }

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

