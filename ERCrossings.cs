public class ERCrossings : MonoBehaviour // TypeDefIndex: 7169
{
	[SerializeField] 
	public ERConnectionData cdata; 
	public List<List<Vector3>> startConnectionV3; 
	public List<List<Vector3>> endConnectionV3; 
	public List<List<Vector3>> leftConnectionV3; 
	public List<List<Vector3>> rightConnectionV3; 
	public List<List<Vector2>> startConnectionUV; 
	public List<List<Vector2>> endConnectionUV; 
	public List<List<Vector2>> leftConnectionUV; 
	public List<List<Vector2>> rightConnectionUV; 
	public List<List<int>> startConnectionTris; 
	public List<List<int>> endConnectionTris; 
	public List<List<int>> leftConnectionTris; 
	public List<List<int>> rightConnectionTris; 
	public List<List<Vector3>> leftSidewalkStartV3; 
	public List<List<Vector3>> rightSidewalkStartV3; 
	public List<List<Vector3>> leftSidewalkEndV3; 
	public List<List<Vector3>> rightSidewalkEndV3; 
	public List<List<Vector2>> leftSidewalkStartUV; 
	public List<List<Vector2>> rightSidewalkStartUV; 
	public List<List<Vector2>> leftSidewalkEndUV; 
	public List<List<Vector2>> rightSidewalkEndUV; 
	public List<List<Vector3>> leftSidewalkLeftV3; 
	public List<List<Vector3>> leftSidewalkRightV3; 
	public List<List<Vector3>> rightSidewalkLeftV3; 
	public List<List<Vector3>> rightSidewalkRightV3; 
	public List<List<Vector2>> leftSidewalkLeftUV; 
	public List<List<Vector2>> leftSidewalkRightUV; 
	public List<List<Vector2>> rightSidewalkLeftUV; 
	public List<List<Vector2>> rightSidewalkRightUV; 
	public List<List<int>> leftSidewalkStartTris; 
	public List<List<int>> rightSidewalkStartTris; 
	public List<List<int>> leftSidewalkEndTris; 
	public List<List<int>> rightSidewalkEndTris; 
	public List<List<int>> leftSidewalkLeftTris; 
	public List<List<int>> leftSidewalkRightTris; 
	public List<List<int>> rightSidewalkLeftTris; 
	public List<List<int>> rightSidewalkRightTris; 
	public List<float> uvArrayFront; 
	public List<float> uvArrayBack; 
	public List<float> uvArrayLeft; 
	public List<float> uvArrayRight; 
	public List<int> OCCODQDOQO; 
	public List<int> OOQODQDOQC; 
	public List<int> OQCCQOCQDQ; 
	public List<int> OQDQOQOCQD; 
	public List<int> ODQDCCQOQD; 
	public List<int> ODOQODQODO; 
	public List<int> OOOQCQDOCD; 
	public List<int> OQCDOOCDCD; 
	public List<int> OCCODQDOQOStart; 
	public List<int> OOQODQDOQCStart; 
	public List<int> OQCCQOCQDQStart; 
	public List<int> OQDQOQOCQDStart; 
	public List<int> ODQDCCQOQDStart; 
	public List<int> ODOQODQODOStart; 
	public List<int> OOOQCQDOCDStart; 
	public List<int> OQCDOOCDCDStart; 
	public List<int> frontLeftRoadInts; 
	public List<int> frontRightRoadInts; 
	public List<int> backLeftRoadInts; 
	public List<int> backRightRoadInts; 
	public List<int> leftLeftRoadInts; 
	public List<int> leftRightRoadInts; 
	public List<int> rightLeftRoadInts; 
	public List<int> rightRightRoadInts; 
	public List<ERSideWalk> sidewalkCorners; 
	public List<float> sidewalkWidths; 
	public List<float> curbHeights; 
	public List<float> curbDepths; 
	public List<bool> beveledCurbs; 
	public List<float> beveledHeights; 
	public List<float> beveledDepths; 
	public List<bool> outerCurbs; 
	public List<bool> lockUVs; 
	public List<Material> materials; 
	public int leftStartSidewalkCornerInt; 
	public int rightStartSidewalkCornerInt; 
	public int leftEndSidewalkCornerInt; 
	public int rightEndSidewalkCornerInt; 
	public int leftLeftSidewalkCornerInt; 
	public int rightLeftSidewalkCornerInt; 
	public int leftRightSidewalkCornerInt; 
	public int rightRightSidewalkCornerInt; 
	public Vector3[] sidewalkControlPoints; 
	public bool[] sidewalkControlStatus; 
	public bool copySettingsFlag; 
	public bool generalSettingsFlag; 
	public bool connectionSettingsFlag; 
	public bool cornerSettingsFlag; 
	public bool sidewalkSettingsFlag; 
	public string[] QDOOOQOOQQQQD; 
	public int selectedConnection; 
	public float startAngle; 
	public bool roundedCorners; 
	public float roundingRadius; 
	public int roundingSegments; 
	public float innerSegmentDistance; 
	public bool tCrossing; 
	public bool tStraightBending; 
	public bool oldTCrossing; 
	public int tCrossingLeftRight; 
	public int oldtCrossingLeftRight; 
	public int geometryType; 
	public float resolution; 
	public bool includeSidewalks; 
	public bool defaultSidewalkEnabledStatus; 
	public bool planarUVs; 
	public float planarTiling; 
	public bool isSceneObject; 
	public int connectionHandling; 
	public List<QDQDOOQQDQODD> roadTypesDynamic; 
	public int frontRoadTypeInt; 
	public double frontRoadTypeID; 
	public float frontRoadWidth; 
	public Material frontMaterial; 
	public Material frontRoadMaterial; 
	public float frontRoadUVTiling; 
	public int backRoadTypeInt; 
	public double backRoadTypeID; 
	public float backRoadWidth; 
	public Material backMaterial; 
	public Material backRoadMaterial; 
	public float backRoadUVTiling; 
	public int leftRoadTypeInt; 
	public double leftRoadTypeID; 
	public float leftRoadWidth; 
	public Material leftMaterial; 
	public Material leftRoadMaterial; 
	public float leftRoadUVTiling; 
	public int rightRoadTypeInt; 
	public double rightRoadTypeID; 
	public float rightRoadWidth; 
	public Material rightMaterial; 
	public Material rightRoadMaterial; 
	public float rightRoadUVTiling; 
	public int selectedRoadType; 
	public bool uniformCornersFlag; 
	public int selectedCorner; 
	public int selectedCornerPreset; 
	public string cornerPresetName; 
	public int selectedSidewalkPreset; 
	public string sidewalkPresetName; 
	public int OCOQDODDQQCorner; 
	public Vector3 leftBottom; 
	public Vector3 rightBottom; 
	public Vector3 leftTop; 
	public Vector3 rightTop; 
	public Vector3 frontCenter; 
	public Vector3 backCenter; 
	public Vector3 leftCenter; 
	public Vector3 rightCenter; 
	public int prefabId; 
	public ERCrossingPrefabs prefabScript; 
	public QDOODOQQDQODD connectionElement; 
	public int crossingOuterElement; 
	public string crossingName; 
	public bool guiChanged; 
	public bool includeSidewalkChangeFlag; 
	public List<Vector3> debugVecs; 
	public List<NormalPairs> normalPairs; 
	public float maxConnectionWidth; 
	public int crossingStructure; 
	public ERModularBase baseScript; 
	public List<ERConnectionSibling> siblings1; 
	public List<ERConnectionSibling> prioritySiblings; 
	public Vector3 crossPointCenter; 
	public List<Vector3> edges; 
	public ERConnectionSibling primaryPriorityConnection; 
	public ERConnectionSibling secondPriorityConnection; 
	public bool adjustMainRadiusFlag; 
	public bool disableAdjustMainRadiusFlag; 
	public bool showScaleSliderAtPrimary; 
	public bool showScaleSliderAtSecondary; 
	public ERRoadWayType priorityWayType; 
	public float leftIntOffset; 
	public float rightIntOffset; 
	public bool isUpdating; 
	public int serializeTest; 
	public int updateQueue; 


	public void Refresh() { }

	public void ODOCCDCQOC() { }

	public Vector3 OOQCQDQCOO(int index, Vector3 p0, Vector3 p1, Vector3 p2, bool update) { }

	public void UpdateAllConnectionAngles() { }

	public void OOOCDCQQCO() { }

	public bool UpdateToRoadType(QDQDOOQQDQODD sourcePreset, ref List<ERModularRoad> updatedRoads) { }

	public bool RoadIsUpdated(ERModularRoad rd, ref List<ERModularRoad> updatedRoads) { }

	public int SetRoadTypeInt(double id) { }

	public void OCQCQODOQC(ERCrossings source, bool refreshFlag) { }

	public void OQCQCOOCDD() { }

	public void OCQDQODOQD(bool sidewalkSceneHandleFlag, bool rebuildRoads) { }

	public void OQCQDQDCOD() { }

	public void ODDDOCDCQO(bool rebuildRoads) { }

	public void OQCQQCQDCQ(int el, List<List<int>> trIntArray, List<float> uvArray, List<List<int>> leftSidewalkIntArray, List<List<int>> rightSidewalkIntArray, int startend) { }

	public void ODQCODQDDQ(int el, Material roadMaterial, int leftCorner, int rightCorner, int leftVecCount, int rightVecCount) { }

	public void OCDDOCDDOQ(List<Vector3> meshVecs, List<int> connectionVecInts, ref List<Vector2> roadShapeVecs, List<List<Vector3>> vecArrays, List<List<Vector3>> leftSidewalkArray, List<List<Vector3>> rightSidewalkArray, int connectionElement, int startend) { }

	public static void ODOODQDCCQ(List<Vector3> sourceVecs, ref List<Vector2> roadShapeVecs, Vector3 centerPoint, Vector3 startPoint, float halfWayDistance) { }

	public static string GetRoadShapeVecString(List<Vector2> vecs, List<Vector2> lvecs, List<Vector2> rvecs, ref int matchCount) { }

	public void ODCCCQCQOO() { }

	public void ODCDCDDOCC(List<SidewalkPresetClass> sidewalkPresets, int el) { }

	public void OCCODQDOCO() { }

	public void OQDOQDQQQQ(int el) { }

	public void OODOQQQQCO() { }

	public void OQCOOQQOOD() { }

	public bool OQDOOCDOCD(ERModularRoad road, float angle) { }

	public void .ctor() { }

}

private sealed class ERCrossings.ᙃ // TypeDefIndex: 7170
{
	public static readonly ERCrossings.ᙃ <>9; 
	public static Comparison<ERConnectionSibling> <>9__203_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <OQDOOCDOCD>b__203_0(ERConnectionSibling x, ERConnectionSibling y) { }

}

