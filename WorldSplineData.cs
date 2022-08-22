public class WorldSplineData // TypeDefIndex: 11408
{	public Vector3[] inputPoints; // 0x10
	public Vector3[] inputTangents; // 0x18
	public float inputLUTInterval; // 0x20
	public List<WorldSplineData.LUTEntry> LUTValues; // 0x28
	public float Length; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int maxPointsIndex; // 0x34


	public void .ctor(WorldSpline worldSpline) { }

	public bool IsSameAs(WorldSpline worldSpline) { }

	public bool IsDifferentTo(WorldSpline worldSpline) { }

	public Vector3 GetStartPoint() { }

	public Vector3 GetEndPoint() { }

	public Vector3 GetStartTangent() { }

	public Vector3 GetEndTangent() { }

	public virtual Vector3 GetTangent(float distance) { }

	public Vector3 GetPointCubicHermite(float distance) { }

	public Vector3 GetTangentCubicHermite(float distance) { }

	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	public void SetDefaultTangents(WorldSpline worldSpline) { }

	private void CreateLookupTable(WorldSpline worldSpline) { }

	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11409
{	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10


	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 11410
{	public float distance; // 0x0
	public Vector3 pos; // 0x4


	public void .ctor(float distance, Vector3 pos) { }

}

