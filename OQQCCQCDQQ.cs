public class OQQCCQCDQQ : MonoBehaviour // TypeDefIndex: 7272
{
	[HideInInspector] 
	public QDQDOOQQDQODD roadType; 
	[HideInInspector] 
	public double roadTypeID; 
	[HideInInspector] 
	public int roadTypeIndex; 
	[HideInInspector] 
	public int geometryType; 
	[HideInInspector] 
	public ERExitType exitType; 
	[HideInInspector] 
	public float offset; 
	[HideInInspector] 
	public int halfwayIndex; 
	[HideInInspector] 
	public int startSplineIndex; 
	[HideInInspector] 
	public int endSplineIndex; 
	[HideInInspector] 
	public Vector3 endSplinePointRight; 
	[HideInInspector] 
	public Vector3 endSplinePointLeft; 
	[HideInInspector] 
	public float startDistance; 
	[HideInInspector] 
	public float endDistance; 
	[HideInInspector] 
	public int markerIndex; 
	[HideInInspector] 
	public int extrusionType; 
	[HideInInspector] 
	public AnimationCurve extrusionCurve; 
	[HideInInspector] 
	public float extrusionDistance; 
	[HideInInspector] 
	public int startDistanceIndex; 
	[HideInInspector] 
	public float startDecalDistance; 
	[HideInInspector] 
	public float fixedDistance; 
	[HideInInspector] 
	public int fixedDistanceIndex; 
	[HideInInspector] 
	public float splitDistance; 
	[HideInInspector] 
	public AnimationCurve splitCurve; 
	[HideInInspector] 
	public float splitEndWidth; 
	[HideInInspector] 
	public float connectionAngle; 
	[HideInInspector] 
	public float connectionRadius; 
	[HideInInspector] 
	public ERModularRoad road; 
	[HideInInspector] 
	public ERCrossingPrefabs connector; 
	[HideInInspector] 
	public Vector3 connectionHandlePosition; 
	[HideInInspector] 
	public Vector3 OCODOQDODQ; 
	[HideInInspector] 
	public Vector3 handleDirection; 
	[HideInInspector] 
	public GameObject surfaceMesh; 
	[HideInInspector] 
	public GameObject exitSignObject; 
	[HideInInspector] 
	public float exitSignObjectOffset; 
	[HideInInspector] 
	public GameObject exitSignObjectInstance; 
	[HideInInspector] 
	public GameObject exitSplitSpawnObject; 
	[HideInInspector] 
	public int exitSplitSpawnType; 
	[HideInInspector] 
	public float exitSplitSpawnDistance; 
	[HideInInspector] 
	public float exitSplitSpawnStartOffset; 
	[HideInInspector] 
	public float exitSplitSpawnOffset; 
	[HideInInspector] 
	public float exitSplitSpawnObjectBounds; 
	[HideInInspector] 
	public List<GameObject> spawnedSplitObjects; 
	[HideInInspector] 
	public List<Vector3> soPointsRightStart; 
	[HideInInspector] 
	public int soRightSplitEndIndex; 
	[HideInInspector] 
	public List<Vector3> soPointsLeftStart; 
	[HideInInspector] 
	public int startLineMarkingDecal; 
	[HideInInspector] 
	public bool startDecalFoldout; 
	[HideInInspector] 
	public int splitLineMarkingDecal1; 
	[HideInInspector] 
	public bool splitDecal1Foldout; 
	[HideInInspector] 
	public int splitLineMarkingDecal2; 
	[HideInInspector] 
	public bool splitDecal2Foldout; 
	[HideInInspector] 
	public List<Vector3> edgeVecs; 
	[HideInInspector] 
	public List<Vector3> vecs; 
	[HideInInspector] 
	public List<Vector2> uvsArray; 
	[HideInInspector] 
	public List<Vector2> uvsArray2; 
	[HideInInspector] 
	public List<Color> customColors; 
	[HideInInspector] 
	public List<Color> colors; 
	[HideInInspector] 
	public List<int> tris; 
	[HideInInspector] 
	private int ᙃ; 
	[HideInInspector] 
	private int ᙄ; 
	[HideInInspector] 
	private int ᙅ; 
	[HideInInspector] 
	private List<Vector3> 4AAAA; 
	[HideInInspector] 
	private List<Vector3> 5AAA1; 
	[HideInInspector] 
	private List<Vector3> 6AAAA; 
	[HideInInspector] 
	private List<float> 7AAA1; 
	[HideInInspector] 
	private List<Vector3> 8AAAA; 
	[HideInInspector] 
	private Vector3 9AAA1; 
	[HideInInspector] 
	private float BAAAA; 
	[HideInInspector] 
	private float CAAA1; 
	[HideInInspector] 
	private float 00AAA; 
	[HideInInspector] 
	private float 10AA1; 
	[HideInInspector] 
	private int 20AAA; 
	[HideInInspector] 
	private int 30AA1; 
	[HideInInspector] 
	public List<Vector3> treeVecs; 
	[HideInInspector] 
	public List<Vector3> detailVecs; 


	public static void OOOCDQDQDC(List<ERMarkerExt> markers, List<OQQCCQCDQQ> exitRoads, ref List<Vector3> splinePoints, ref List<float> tValues) { }

	public static void ODOCDDDDDO(List<ERMarkerExt> markers, OQQCCQCDQQ exitRoad, ref List<Vector3> splinePoints, ref List<float> tValues, int currentInt) { }

	public static void OQCCQOQDDO(ERModularBase baseScript, ERModularRoad road, List<OQQCCQCDQQ> exitRoads, List<ERMarkerExt> markers, ref List<Vector3> soSplinePointsLeft, ref List<Vector3> soSplinePointsRight, ref bool hasExits, List<float> leftIndentFloats, List<float> rightIndentFloats, List<float> leftSurroundingFloats, List<float> rightSurroundingFloats, ref List<Vector3> surfaceVecs) { }

	public static void OCCCOOCCQC(ERModularBase baseScript, ERModularRoad road, OQQCCQCDQQ exitRoad, ref List<Vector3> soSplinePointsLeft, ref List<Vector3> soSplinePointsRight, List<float> leftIndentFloats, List<float> rightIndentFloats, List<float> leftSurroundingFloats, List<float> rightSurroundingFloats, ref List<Vector3> roadSurfaceVecs) { }

	public void BuildMeshInit(OQQCCQCDQQ exitRoad, List<Vector3> vecs, List<Vector2> uvs, List<int> tris, List<Color> colors, Material mat, ERModularRoad road) { }

	public void OQDDCODQCD() { }

	public void SpawnSplitObjects() { }

	public void OQDDCCQOOO(ref int curGo, Vector3 v) { }

	public static void OOOOOCODQO(OQQCCQCDQQ exitRoad, int vecCount, List<Vector3> vecs, List<Vector2> uvsArray, List<int> tris) { }

	public static void ODQCODOCDO(OQQCCQCDQQ exitRoad, int vecCount, List<Vector3> vecs, List<Vector2> uvsArray, List<int> tris, int decalIndex) { }

	public static void OQCCDDDOQQ(int i, int j, Vector3 prevPos, List<Vector3> edgeVecs, List<Vector3> soSplinePointsRight, float angleThreshold, ref List<Vector3> tmpvecs) { }

	private static void OOOQCQDCDD(int curLeft, int endLeft, int curRight, int endRight, List<int> rightInts, List<Vector3> vecs, ref List<int> tris) { }

	public static void ODCDCQCOCQ(List<Vector3> vecs, ref List<int> tris) { }

	public static void ODQDQDCOQD(ERModularBase baseScript, ERModularRoad road, OQQCCQCDQQ exitRoad, ref List<Vector3> soSplinePointsLeft, ref List<Vector3> soSplinePointsRight) { }

	public static void ODDDDDDQQD(ERModularBase baseScript, ERModularRoad road, ERMarkerExt marker, ref List<Vector3> soSplinePointsLeft, ref List<Vector3> soSplinePointsRight) { }

	public static void OQDOQDDCDD(ERModularBase baseScript, ERModularRoad road, OQQCCQCDQQ exitRoad, List<ERMarkerExt> markers, List<List<Vector3>> exitOuterVerticesExtrusion, List<List<Vector3>> exitOuterVerticesFixed, List<List<Vector3>> exitOuterVerticesCurve, List<Vector3> exitInnerVertices) { }

	public static void OCDQCQDDOQ(ERModularBase baseScript, ERModularRoad road, List<ERMarkerExt> markers) { }

	public static void OCDDDOQCCO(ERModularBase baseScript, List<ERMarkerExt> markers, ref List<Vector3> vecs, ref List<Vector2> uvsArray, ref List<Vector2> uvsArray2, ref List<Color> customColors, ref List<Color> colors, ref List<List<int>> tris, ref Material[] materialsList) { }

	public static void OCDDCCQCCD(ref int triIndex, ref List<List<int>> tris, ref Material[] materialsList, Material m) { }

	public static float OQQDDDDDOC(Vector3 v, List<Vector3> soSplinePointsLeft, List<Vector3> soSplinePointsRight, ref int cInt, bool flag, ref int match) { }

	private static void ODDDOCDCQO(List<Vector3> vecs, List<Vector2> uvs, List<int> tris, List<Color> colors, Material mat, GameObject go, ERModularRoad road) { }

	private void OCCDCQQDOQ(List<Vector3> vecs, List<int> connectionInts, List<Vector3> surfaceVecs, Vector3 prefDirVec) { }

	public Vector3 ODCCQQDQQQ() { }

	public void OCQOQQCDOD(List<Vector3> surfaceVecs, List<Vector2> uvs, int firstSection, int secondSection) { }

	public void .ctor() { }

}

