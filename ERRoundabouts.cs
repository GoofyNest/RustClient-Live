public class ERRoundabouts : MonoBehaviour // TypeDefIndex: 7148
{
	public float roundAboutRadius; 
	public float prevRoundAboutRadius; 
	public float roundAboutResolution; 
	public float prevRoundAboutResolution; 
	public float rDist; 
	public Vector3 raStartPos; 
	public float roundaboutWidth; 
	public float prevRoundaboutWidth; 
	public int roadTypeInt; 
	public int prevRoadTypeInt; 
	public float roadWidth; 
	public float prevRoadWidth; 
	public bool lockLeftRightRoundingRadius; 
	public float leftRoundingRadius; 
	public float prevLeftRoundingRadius; 
	public float rightRoundingRadius; 
	public float prevRightRoundingRadius; 
	public int roundingSegments; 
	public float connectionLength; 
	public float maxRoadWidth; 
	public float maxRoundingRadius; 
	public List<Vector3> meshVecs; 
	public List<Vector3> mainRightPoints; 
	public List<Vector3> mainCenterPoints; 
	public List<Vector3> mainLeftPoints; 
	public List<Vector3> OCCDQOCCDQ; 
	public List<Vector2> mainRightPointsUVs; 
	public List<Vector2> mainCenterPointsUVs; 
	public List<Vector2> mainLeftPointsUVs; 
	public List<Vector2> OCCDQOCCDQUVs; 
	public List<Vector3> innerRoundaboutSidewalkV3; 
	public List<Vector2> innerRoundaboutSidewalUV; 
	public List<int> innerRoundaboutSidewalTris; 
	public Material innerRoundaboutSidewalkMaterial; 
	public List<int> innerRoundaboutSidewalkIntsStart; 
	public List<int> innerRoundaboutSidewalkIntsEnd; 
	public int innerSidewalkSegments; 
	public Vector3 leftPoint; 
	public Vector3 leftPoint1; 
	public Vector3 rightPoint; 
	public Vector3 rightPoint1; 
	public Vector3 centerOnLine; 
	public Vector3 leftOuterPoint; 
	public Vector3 rightOuterPoint; 
	public Vector3 pl; 
	public Vector3 pr; 
	public List<Vector3> edgePoints; 
	public int newSegmentInt; 
	public int prevNewSegmentInt; 
	public List<ERRoundaboutElement> connections; 
	public string[] QDOOOQOOQQQQD; 
	public int selectedConnection; 
	public int activeConnection; 
	public int tmpSelectedConnection; 
	public int minStartInt; 
	public int maxEndInt; 
	public int centerInt; 
	public int leftOuterInt; 
	public int rightOuterInt; 
	public List<Vector3> leftOuterSegments; 
	public List<Vector3> leftInnerSegments; 
	public List<Vector3> rightOuterSegments; 
	public List<Vector3> rightInnerSegments; 
	public List<Vector2> leftOuterSegmentsUVs; 
	public List<Vector2> leftInnerSegmentsUVs; 
	public List<Vector2> rightOuterSegmentsUVs; 
	public List<Vector2> rightInnerSegmentsUVs; 
	public Vector3 outerCenterPoint; 
	public bool blendFlag; 
	public Material mainRoadMaterial; 
	public Material roadMaterial; 
	public Material connectionMaterial; 
	public Material defaultConnectionMaterial; 
	public double roadType; 
	public double roadTypeTimestamp; 
	public List<Vector3> innerRoundaboutPoints; 
	public List<Vector2> innerRoundaboutUVs; 
	public float innerSegmentDistance; 
	public float innerSidewalkWidth1; 
	public float innerSidewalkWidth2; 
	public float innerCurbHeight; 
	public float innerCurbDepth; 
	public bool innerBeveledCurb; 
	public float innerBeveledHeight; 
	public float innerBeveledDepth; 
	public bool innerOuterCurb; 
	public bool innerRoadSideCurbUVControl; 
	public bool innerOuterSideCurbUVControl; 
	public Material innerSidewalkMaterial; 
	public List<float> innerSidewalkUVs; 
	public List<float> innerCurbUVs; 
	public int selectedCorner; 
	public int selectedCornerPreset; 
	public int selectedSidewalkPreset; 
	public string sidewalkPresetName; 
	public int innerRoundaboutPreset; 
	public bool leftFlag; 
	public bool rightFlag; 
	private bool ᙃ; 
	public ERCrossingPrefabs prefabScript; 
	public QDOODOQQDQODD connectionElement; 
	public ERModularBase baseScript; 
	public bool isSceneObject; 
	public bool guiChanged; 
	public string crossingName; 
	public bool activeSidewalks; 
	public bool newConnectionFlag; 
	public Vector3 testIndentMiddlePoint; 
	public List<QDQDOOQQDQODD> roadTypesDynamic; 


	private void Start() { }

	public bool UpdateToRoadType(QDQDOOQQDQODD sourcePreset) { }

	public void ResetData() { }

	public void ODQDCCOQOD() { }

	public void OOQQDCCCCC() { }

	public void GetConnectionData() { }

	public void UpdateMinMaxInts() { }

	public void ChecknewSegmentInt() { }

	public int GetRoadPresetInt(double id) { }

	public void OCQCQODOQC(ERRoundabouts source, bool refreshFlag) { }

	public void OCDCOQOOQO() { }

	public void ODCDCDDOCC(List<SidewalkPresetClass> sidewalkPresets, int el) { }

	public void OOCDDOQDDO() { }

	public void OQQCDOQOOQ() { }

	public void OQCQDQDCOD(int currentIndex) { }

	public void OQQOCQQDOQ(ref List<Vector3> OCCDQOCCDQ, ref List<Vector3> innerSegmentPoints, int leftRight, int startElement, Vector3 leftPoint, Vector3 rightPoint, Vector3 forward, int currentIndex) { }

	public void OOCCDCDOQC(int currentIndex) { }

	public void ODDDOCDCQO() { }

	public void OQCQQCQDCQ(int el, List<int> trIntArray, List<float> uvArray, List<List<int>> leftSidewalkIntArray, List<List<int>> rightSidewalkIntArray, int startend) { }

	public void OCDDOCDDOQ(List<Vector3> meshVecs, List<int> connectionVecInts, ref List<Vector2> roadShapeVecs, List<Vector2> vecArrays, List<List<Vector3>> leftSidewalkArray, List<List<Vector3>> rightSidewalkArray, int connectionElement, int startend) { }

	public void ODQCODQDDQ(int el, Material roadMaterial, int leftVecCount, int rightVecCount) { }

	public void ODCQOCOOQO() { }

	public void OCQOCDQQQD(int el) { }

	public static bool OQQCODDOOQ(int el, float roundaboutIndent, Vector3 prevVec, bool boolCheck, ref Vector3 vec, ref int indentBorderInt) { }

	public void ODQOOCQDDD(float minSurrounding, Vector3 middleVec, Vector3 origVec, bool boolCheck, ref Vector3 vec) { }

	public void CheckAgainstFirstSurroundingVec(Vector3 firstIndent, Vector3 firstSurrounding, bool boolCheck, ref Vector3 vec) { }

	public static Vector3 OODOQDOODO(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4) { }

	public static Vector3 OQDDDODCOC(Vector3 point, Vector3 pivot, Quaternion angle) { }

	public void .ctor() { }

}

