public class ODCCODOCQQ : MonoBehaviour // TypeDefIndex: 7205
{	// Fields
	public static GameObject rtg; // 0x0
	public static GameObject swgLeft; // 0x8
	public static GameObject swgRight; // 0x10
	public static Vector3 camdir; // 0x18
	public static List<List<Vector3>> vecs; // 0x28

	// Methods

	// RVA: 0x41FFD0 Offset: 0x41F3D0 VA: 0x18041FFD0
	public static void OODDQCQQDQ(ERModularBase baseScript, ERModularRoad scr) { }

	// RVA: 0x41AF30 Offset: 0x41A330 VA: 0x18041AF30
	public static void CleanMeshData(Mesh m, List<List<int>> mtris, ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs2, ref List<Vector3> normals, ref List<Vector4> tangents, ref List<Color> colors, ref List<List<int>> tris) { }

	// RVA: 0x41C2C0 Offset: 0x41B6C0 VA: 0x18041C2C0
	public static void OCDCQCOQQO(Mesh mesh) { }

	// RVA: 0x41E810 Offset: 0x41DC10 VA: 0x18041E810
	public static void OOCQQCOQQC(Mesh mesh) { }

	// RVA: 0x41B690 Offset: 0x41AA90 VA: 0x18041B690
	public static void GenerateWaypoints(ERModularRoad scr, float distance) { }

	// RVA: 0x420620 Offset: 0x41FA20 VA: 0x180420620
	public static void OOQDCQODOD(List<SelectedObject> selectedObjects, int alignType) { }

	// RVA: 0x41E7E0 Offset: 0x41DBE0 VA: 0x18041E7E0
	public static void OOCDQDQDCQ(GameObject go, SideObject so, List<Vector3> vecs, List<Vector2> uvs, List<Vector2> uvs1, List<Color> color, List<Vector4> tangents, List<int> triangles, List<Vector3> normals, List<int> normalArray1, List<int> normalArray2) { }

	// RVA: 0x41BCE0 Offset: 0x41B0E0 VA: 0x18041BCE0
	public static void GetRoadShape(float width, int subSegments, ref List<Vector2> roadShape, ref List<float> uvs, ref List<float> uvs1, float dir) { }

	// RVA: 0x41BEC0 Offset: 0x41B2C0 VA: 0x18041BEC0
	public static void GetRoadShape(float oldWidth, QDQDOOQQDQODD roadType, float dir) { }

	// RVA: 0x423A70 Offset: 0x422E70 VA: 0x180423A70
	public static void UpdateRoadType(ERModularBase scr, int index) { }

	// RVA: 0x4228E0 Offset: 0x421CE0 VA: 0x1804228E0
	public static bool UpdateRoadTypeByRoad(ERModularBase scr, ERModularRoad road, int index, QDQDOOQQDQODD type) { }

	// RVA: 0x41D0E0 Offset: 0x41C4E0 VA: 0x18041D0E0
	public static int OCDQQQDDQO(List<Vector2> roadShape) { }

	// RVA: 0x41CDC0 Offset: 0x41C1C0 VA: 0x18041CDC0
	public static void OCDQCDQQDD(ref List<ERMarkerExt> tmpMarkersExt) { }

	// RVA: 0x41D210 Offset: 0x41C610 VA: 0x18041D210
	public static void ODOCDOQDDQ(QDQDOOQQDQODD roadType) { }

	// RVA: 0x422560 Offset: 0x421960 VA: 0x180422560
	public static void RebuildMainRoadShape(QDQDOOQQDQODD roadType) { }

	// RVA: 0x421DE0 Offset: 0x4211E0 VA: 0x180421DE0
	public static void OQDCDQDCQC(QDQDOOQQDQODD roadType, ref List<Vector2> roadShape, ref List<float> roadShapeUVs, ref List<bool> doConnectionTri, ref List<bool> hardEdge, ref int currentMostLeftInt, ref int currentMostRightInt, ref int sectionRoadShapeCols, int leftright, int lineIndexTarget, bool transition, List<Vector2> origRoadShape) { }

	// RVA: 0x41E910 Offset: 0x41DD10 VA: 0x18041E910
	public static List<int> OODCQDDQDC(List<Vector2> _rs1, List<bool> _hd1, int cols1, List<Vector2> _rs2, List<bool> _hd2, int cols2, ref List<int> tris, bool flipNormals, int vecCount, int i1, int i2, int last1, int last2) { }

	// RVA: 0x420430 Offset: 0x41F830 VA: 0x180420430
	public static void OOQCCCDODD(QDQDOOQQDQODD roadType, ref List<Vector2> roadShapeVecs, ref List<float> roadShapeUVs, ref List<bool> hardEdge, ref int rightOuterIndex) { }

	// RVA: 0x423B00 Offset: 0x422F00 VA: 0x180423B00
	public static void VisualizeRoadType(ERModularBase baseScript, GameObject prefab, QDQDOOQQDQODD rt, Vector3 pos, Vector3 dir) { }

	// RVA: 0x41D420 Offset: 0x41C820 VA: 0x18041D420
	public static void ODODDQCQQC(QDQDOOQQDQODD rt) { }

	// RVA: 0x41F1E0 Offset: 0x41E5E0 VA: 0x18041F1E0
	public static void OODDDCCOQO(List<Vector3> cvecs, float OOCODCCCOQ, float OQQDDDQDOQ, float OCCOCCCODQ, List<float> breakpoints, float OQQOOQOOQQ, Vector3 startDir, Vector3 endDir, ref List<Vector3> vecs, float length, Vector3 firstRounding, float uvRatio) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void RoadShapeChangeTriangulation(List<Vector3> shape1, List<Vector3> shape2, int startIndex1, int endIndex1, int startIndex2, int endIndex2, ref List<int> tris) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x4241F0 Offset: 0x4235F0 VA: 0x1804241F0
	private static void .cctor() { }

}

