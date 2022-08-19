public class WorldSplineData // TypeDefIndex: 11408
{	// Fields
	public Vector3[] inputPoints; // 0x10
	public Vector3[] inputTangents; // 0x18
	public float inputLUTInterval; // 0x20
	public List<WorldSplineData.LUTEntry> LUTValues; // 0x28
	public float Length; // 0x30
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int maxPointsIndex; // 0x34

	// Methods

	// RVA: 0x1A90530 Offset: 0x1A8F930 VA: 0x181A90530
	public void .ctor(WorldSpline worldSpline) { }

	// RVA: 0x1A90400 Offset: 0x1A8F800 VA: 0x181A90400
	public bool IsSameAs(WorldSpline worldSpline) { }

	// RVA: 0x1A90370 Offset: 0x1A8F770 VA: 0x181A90370
	public bool IsDifferentTo(WorldSpline worldSpline) { }

	// RVA: 0x1A900D0 Offset: 0x1A8F4D0 VA: 0x181A900D0
	public Vector3 GetStartPoint() { }

	// RVA: 0x1A8F990 Offset: 0x1A8ED90 VA: 0x181A8F990
	public Vector3 GetEndPoint() { }

	// RVA: 0x1A90110 Offset: 0x1A8F510 VA: 0x181A90110
	public Vector3 GetStartTangent() { }

	// RVA: 0x1A8F9F0 Offset: 0x1A8EDF0 VA: 0x181A8F9F0
	public Vector3 GetEndTangent() { }

	// RVA: 0x1A90180 Offset: 0x1A8F580 VA: 0x181A90180 Slot: 4
	public virtual Vector3 GetTangent(float distance) { }

	// RVA: 0x1A90090 Offset: 0x1A8F490 VA: 0x181A90090
	public Vector3 GetPointCubicHermite(float distance) { }

	// RVA: 0x1A90150 Offset: 0x1A8F550 VA: 0x181A90150
	public Vector3 GetTangentCubicHermite(float distance) { }

	// RVA: 0x1A8FA50 Offset: 0x1A8EE50 VA: 0x181A8FA50
	public Vector3 GetPointAndTangentCubicHermite(float distance, out Vector3 tangent) { }

	// RVA: 0x1A90490 Offset: 0x1A8F890 VA: 0x181A90490
	public void SetDefaultTangents(WorldSpline worldSpline) { }

	// RVA: 0x1A8F680 Offset: 0x1A8EA80 VA: 0x181A8F680
	private void CreateLookupTable(WorldSpline worldSpline) { }

	// RVA: 0x1A8F490 Offset: 0x1A8E890 VA: 0x181A8F490
	private void AddEntry(float distance, Vector3 pos) { }

}

public class WorldSplineData.LUTEntry // TypeDefIndex: 11409
{	// Fields
	public List<WorldSplineData.LUTEntry.LUTPoint> points; // 0x10

	// Methods

	// RVA: 0x1A8F420 Offset: 0x1A8E820 VA: 0x181A8F420
	public void .ctor() { }

}

public struct WorldSplineData.LUTEntry.LUTPoint // TypeDefIndex: 11410
{	// Fields
	public float distance; // 0x0
	public Vector3 pos; // 0x4

	// Methods

	// RVA: 0x22A320 Offset: 0x229720 VA: 0x18022A320
	public void .ctor(float distance, Vector3 pos) { }

}

