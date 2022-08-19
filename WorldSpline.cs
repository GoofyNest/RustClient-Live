public class WorldSpline : MonoBehaviour // TypeDefIndex: 11407
{	// Fields
	public int dataIndex; // 0x18
	public Vector3[] points; // 0x20
	public Vector3[] tangents; // 0x28
	[RangeAttribute] // RVA: 0xAC130 Offset: 0xAB530 VA: 0x1800AC130
	public float lutInterval; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool showGizmos; // 0x34
	private static List<Vector3> visualSplineList; // 0x0
	private WorldSplineData privateData; // 0x38

	// Methods

	// RVA: 0x1A91400 Offset: 0x1A90800 VA: 0x181A91400
	public WorldSplineData GetData() { }

	// RVA: 0x1A92DC0 Offset: 0x1A921C0 VA: 0x181A92DC0
	public void SetAll(Vector3[] points, Vector3[] tangents, float lutInterval) { }

	// RVA: 0x1A909F0 Offset: 0x1A8FDF0 VA: 0x181A909F0
	public void CheckValidity() { }

	// RVA: 0x1A92C30 Offset: 0x1A92030 VA: 0x181A92C30 Slot: 4
	protected virtual void OnDrawGizmosSelected() { }

	// RVA: 0x1A90C90 Offset: 0x1A90090 VA: 0x181A90C90
	protected static void DrawSplineGizmo(WorldSpline ws, Color splineColour) { }

	// RVA: 0x1A92820 Offset: 0x1A91C20 VA: 0x181A92820
	private static Vector3[] GetVisualSpline(WorldSpline ws, WorldSplineData data, float distBetweenPoints) { }

	// RVA: 0x1A91D00 Offset: 0x1A91100 VA: 0x181A91D00
	public Vector3 GetStartPointWorld() { }

	// RVA: 0x1A915F0 Offset: 0x1A909F0 VA: 0x181A915F0
	public Vector3 GetEndPointWorld() { }

	// RVA: 0x1A91D90 Offset: 0x1A91190 VA: 0x181A91D90
	public Vector3 GetStartTangentWorld() { }

	// RVA: 0x1A91690 Offset: 0x1A90A90 VA: 0x181A91690
	public Vector3 GetEndTangentWorld() { }

	// RVA: 0x1A92420 Offset: 0x1A91820 VA: 0x181A92420
	public Vector3 GetTangentWorld(float distance) { }

	// RVA: 0x1A92280 Offset: 0x1A91680 VA: 0x181A92280
	public Vector3 GetTangentWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A920D0 Offset: 0x1A914D0 VA: 0x181A920D0
	public Vector3 GetTangentCubicHermiteWorld(float distance) { }

	// RVA: 0x1A91F20 Offset: 0x1A91320 VA: 0x181A91F20
	public Vector3 GetTangentCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A91A40 Offset: 0x1A90E40 VA: 0x181A91A40
	public Vector3 GetPointCubicHermiteWorld(float distance) { }

	// RVA: 0x1A91B00 Offset: 0x1A90F00 VA: 0x181A91B00
	public Vector3 GetPointCubicHermiteWorld(float distance, WorldSplineData data) { }

	// RVA: 0x1A91930 Offset: 0x1A90D30 VA: 0x181A91930
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, out Vector3 tangent) { }

	// RVA: 0x1A91830 Offset: 0x1A90C30 VA: 0x181A91830
	public Vector3 GetPointAndTangentCubicHermiteWorld(float distance, WorldSplineData data, out Vector3 tangent) { }

	// RVA: 0x1A91BB0 Offset: 0x1A90FB0 VA: 0x181A91BB0
	public Vector3[] GetPointsWorld() { }

	// RVA: 0x1A925D0 Offset: 0x1A919D0 VA: 0x181A925D0
	public Vector3[] GetTangentsWorld() { }

	// RVA: 0x1A92CB0 Offset: 0x1A920B0 VA: 0x181A92CB0
	private static Vector3[] PointsToWorld(Vector3[] points, Transform tr) { }

	// RVA: 0x1A92E10 Offset: 0x1A92210 VA: 0x181A92E10
	private static Vector3[] TangentsToWorld(Vector3[] tangents, Transform tr) { }

	// RVA: 0x1A93090 Offset: 0x1A92490 VA: 0x181A93090
	public void .ctor() { }

	// RVA: 0x1A93030 Offset: 0x1A92430 VA: 0x181A93030
	private static void .cctor() { }

}

