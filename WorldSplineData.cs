public class WorldSplineData // TypeDefIndex: 13162
{
	public Vector3[] inputPoints; 
	public Vector3[] inputTangents; 
	public float inputLUTInterval; 
	public List<WorldSplineData.LUTEntry> LUTValues; 
	public float Length; 
	[SerializeField] 
	private int maxPointsIndex; 


	public void .ctor(WorldSpline worldSpline) { }

	public bool IsSameAs(WorldSpline worldSpline) { }

	public bool IsDifferentTo(WorldSpline worldSpline) { }

	public Vector3 GetStartPoint() { }

	public Vector3 GetEndPoint() { }

	public Vector3 GetStartTangent() { }

	public Vector3 GetEndTangent() { }

	public Vector3 GetPointCubicHermite(float distance) { }

	public Vector3 GetTangentCubicHermite(float distance) { }

	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	public void SetDefaultTangents(WorldSpline worldSpline) { }

	public bool DetectSplineProblems(WorldSpline worldSpline) { }

	private void CreateLookupTable(WorldSpline worldSpline) { }

	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 13163
{
	public List<WorldSplineData.LUTEntry.LUTPoint> points; 


	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 13164
{
	public float distance; 
	public Vector3 pos; 


	public void .ctor(float distance, Vector3 pos) { }

}

