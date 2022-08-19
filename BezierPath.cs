public class BezierPath // TypeDefIndex: 11732
{	// Fields
	public int SegmentsPerCurve; // 0x10
	public float MINIMUM_SQR_DISTANCE; // 0x14
	public float DIVISION_THRESHOLD; // 0x18
	private List<Vector2> controlPoints; // 0x20
	private int curveCount; // 0x28

	// Methods

	// RVA: 0x11CEEE0 Offset: 0x11CE2E0 VA: 0x1811CEEE0
	public void .ctor() { }

	// RVA: 0x11CEDC0 Offset: 0x11CE1C0 VA: 0x1811CEDC0
	public void SetControlPoints(List<Vector2> newControlPoints) { }

	// RVA: 0x11CEE50 Offset: 0x11CE250 VA: 0x1811CEE50
	public void SetControlPoints(Vector2[] newControlPoints) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public List<Vector2> GetControlPoints() { }

	// RVA: 0x11CE5D0 Offset: 0x11CD9D0 VA: 0x1811CE5D0
	public void Interpolate(List<Vector2> segmentPoints, float scale) { }

	// RVA: 0x11CE9D0 Offset: 0x11CDDD0 VA: 0x1811CE9D0
	public void SamplePoints(List<Vector2> sourcePoints, float minSqrDistance, float maxSqrDistance, float scale) { }

	// RVA: 0x11CD960 Offset: 0x11CCD60 VA: 0x1811CD960
	public Vector2 CalculateBezierPoint(int curveIndex, float t) { }

	// RVA: 0x11CE030 Offset: 0x11CD430 VA: 0x1811CE030
	public List<Vector2> GetDrawingPoints0() { }

	// RVA: 0x11CE130 Offset: 0x11CD530 VA: 0x1811CE130
	public List<Vector2> GetDrawingPoints1() { }

	// RVA: 0x11CE420 Offset: 0x11CD820 VA: 0x1811CE420
	public List<Vector2> GetDrawingPoints2() { }

	// RVA: 0x11CDC60 Offset: 0x11CD060 VA: 0x1811CDC60
	private List<Vector2> FindDrawingPoints(int curveIndex) { }

	// RVA: 0x11CDD70 Offset: 0x11CD170 VA: 0x1811CDD70
	private int FindDrawingPoints(int curveIndex, float t0, float t1, List<Vector2> pointList, int insertionIndex) { }

	// RVA: 0x11CDAE0 Offset: 0x11CCEE0 VA: 0x1811CDAE0
	private Vector2 CalculateBezierPoint(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

}

