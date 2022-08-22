public class ERCrossings : MonoBehaviour // TypeDefIndex: 7169
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public ERConnectionData cdata; // 0x18
	public List<List<Vector3>> startConnectionV3; // 0x20
	public List<List<Vector3>> endConnectionV3; // 0x28
	public List<List<Vector3>> leftConnectionV3; // 0x30
	public List<List<Vector3>> rightConnectionV3; // 0x38
	public List<List<Vector2>> startConnectionUV; // 0x40
	public List<List<Vector2>> endConnectionUV; // 0x48
	public List<List<Vector2>> leftConnectionUV; // 0x50
	public List<List<Vector2>> rightConnectionUV; // 0x58
	public List<List<int>> startConnectionTris; // 0x60
	public List<List<int>> endConnectionTris; // 0x68
	public List<List<int>> leftConnectionTris; // 0x70
	public List<List<int>> rightConnectionTris; // 0x78
	public List<List<Vector3>> leftSidewalkStartV3; // 0x80
	public List<List<Vector3>> rightSidewalkStartV3; // 0x88
	public List<List<Vector3>> leftSidewalkEndV3; // 0x90
	public List<List<Vector3>> rightSidewalkEndV3; // 0x98
	public List<List<Vector2>> leftSidewalkStartUV; // 0xA0
	public List<List<Vector2>> rightSidewalkStartUV; // 0xA8
	public List<List<Vector2>> leftSidewalkEndUV; // 0xB0
	public List<List<Vector2>> rightSidewalkEndUV; // 0xB8
	public List<List<Vector3>> leftSidewalkLeftV3; // 0xC0
	public List<List<Vector3>> leftSidewalkRightV3; // 0xC8
	public List<List<Vector3>> rightSidewalkLeftV3; // 0xD0
	public List<List<Vector3>> rightSidewalkRightV3; // 0xD8
	public List<List<Vector2>> leftSidewalkLeftUV; // 0xE0
	public List<List<Vector2>> leftSidewalkRightUV; // 0xE8
	public List<List<Vector2>> rightSidewalkLeftUV; // 0xF0
	public List<List<Vector2>> rightSidewalkRightUV; // 0xF8
	public List<List<int>> leftSidewalkStartTris; // 0x100
	public List<List<int>> rightSidewalkStartTris; // 0x108
	public List<List<int>> leftSidewalkEndTris; // 0x110
	public List<List<int>> rightSidewalkEndTris; // 0x118
	public List<List<int>> leftSidewalkLeftTris; // 0x120
	public List<List<int>> leftSidewalkRightTris; // 0x128
	public List<List<int>> rightSidewalkLeftTris; // 0x130
	public List<List<int>> rightSidewalkRightTris; // 0x138
	public List<float> uvArrayFront; // 0x140
	public List<float> uvArrayBack; // 0x148
	public List<float> uvArrayLeft; // 0x150
	public List<float> uvArrayRight; // 0x158
	public List<int> OCCODQDOQO; // 0x160
	public List<int> OOQODQDOQC; // 0x168
	public List<int> OQCCQOCQDQ; // 0x170
	public List<int> OQDQOQOCQD; // 0x178
	public List<int> ODQDCCQOQD; // 0x180
	public List<int> ODOQODQODO; // 0x188
	public List<int> OOOQCQDOCD; // 0x190
	public List<int> OQCDOOCDCD; // 0x198
	public List<int> OCCODQDOQOStart; // 0x1A0
	public List<int> OOQODQDOQCStart; // 0x1A8
	public List<int> OQCCQOCQDQStart; // 0x1B0
	public List<int> OQDQOQOCQDStart; // 0x1B8
	public List<int> ODQDCCQOQDStart; // 0x1C0
	public List<int> ODOQODQODOStart; // 0x1C8
	public List<int> OOOQCQDOCDStart; // 0x1D0
	public List<int> OQCDOOCDCDStart; // 0x1D8
	public List<int> frontLeftRoadInts; // 0x1E0
	public List<int> frontRightRoadInts; // 0x1E8
	public List<int> backLeftRoadInts; // 0x1F0
	public List<int> backRightRoadInts; // 0x1F8
	public List<int> leftLeftRoadInts; // 0x200
	public List<int> leftRightRoadInts; // 0x208
	public List<int> rightLeftRoadInts; // 0x210
	public List<int> rightRightRoadInts; // 0x218
	public List<ERSideWalk> sidewalkCorners; // 0x220
	public List<float> sidewalkWidths; // 0x228
	public List<float> curbHeights; // 0x230
	public List<float> curbDepths; // 0x238
	public List<bool> beveledCurbs; // 0x240
	public List<float> beveledHeights; // 0x248
	public List<float> beveledDepths; // 0x250
	public List<bool> outerCurbs; // 0x258
	public List<bool> lockUVs; // 0x260
	public List<Material> materials; // 0x268
	public int leftStartSidewalkCornerInt; // 0x270
	public int rightStartSidewalkCornerInt; // 0x274
	public int leftEndSidewalkCornerInt; // 0x278
	public int rightEndSidewalkCornerInt; // 0x27C
	public int leftLeftSidewalkCornerInt; // 0x280
	public int rightLeftSidewalkCornerInt; // 0x284
	public int leftRightSidewalkCornerInt; // 0x288
	public int rightRightSidewalkCornerInt; // 0x28C
	public Vector3[] sidewalkControlPoints; // 0x290
	public bool[] sidewalkControlStatus; // 0x298
	public bool copySettingsFlag; // 0x2A0
	public bool generalSettingsFlag; // 0x2A1
	public bool connectionSettingsFlag; // 0x2A2
	public bool cornerSettingsFlag; // 0x2A3
	public bool sidewalkSettingsFlag; // 0x2A4
	public string[] QDOOOQOOQQQQD; // 0x2A8
	public int selectedConnection; // 0x2B0
	public float startAngle; // 0x2B4
	public bool roundedCorners; // 0x2B8
	public float roundingRadius; // 0x2BC
	public int roundingSegments; // 0x2C0
	public float innerSegmentDistance; // 0x2C4
	public bool tCrossing; // 0x2C8
	public bool tStraightBending; // 0x2C9
	public bool oldTCrossing; // 0x2CA
	public int tCrossingLeftRight; // 0x2CC
	public int oldtCrossingLeftRight; // 0x2D0
	public int geometryType; // 0x2D4
	public float resolution; // 0x2D8
	public bool includeSidewalks; // 0x2DC
	public bool defaultSidewalkEnabledStatus; // 0x2DD
	public bool planarUVs; // 0x2DE
	public float planarTiling; // 0x2E0
	public bool isSceneObject; // 0x2E4
	public int connectionHandling; // 0x2E8
	public List<QDQDOOQQDQODD> roadTypesDynamic; // 0x2F0
	public int frontRoadTypeInt; // 0x2F8
	public double frontRoadTypeID; // 0x300
	public float frontRoadWidth; // 0x308
	public Material frontMaterial; // 0x310
	public Material frontRoadMaterial; // 0x318
	public float frontRoadUVTiling; // 0x320
	public int backRoadTypeInt; // 0x324
	public double backRoadTypeID; // 0x328
	public float backRoadWidth; // 0x330
	public Material backMaterial; // 0x338
	public Material backRoadMaterial; // 0x340
	public float backRoadUVTiling; // 0x348
	public int leftRoadTypeInt; // 0x34C
	public double leftRoadTypeID; // 0x350
	public float leftRoadWidth; // 0x358
	public Material leftMaterial; // 0x360
	public Material leftRoadMaterial; // 0x368
	public float leftRoadUVTiling; // 0x370
	public int rightRoadTypeInt; // 0x374
	public double rightRoadTypeID; // 0x378
	public float rightRoadWidth; // 0x380
	public Material rightMaterial; // 0x388
	public Material rightRoadMaterial; // 0x390
	public float rightRoadUVTiling; // 0x398
	public int selectedRoadType; // 0x39C
	public bool uniformCornersFlag; // 0x3A0
	public int selectedCorner; // 0x3A4
	public int selectedCornerPreset; // 0x3A8
	public string cornerPresetName; // 0x3B0
	public int selectedSidewalkPreset; // 0x3B8
	public string sidewalkPresetName; // 0x3C0
	public int OCOQDODDQQCorner; // 0x3C8
	public Vector3 leftBottom; // 0x3CC
	public Vector3 rightBottom; // 0x3D8
	public Vector3 leftTop; // 0x3E4
	public Vector3 rightTop; // 0x3F0
	public Vector3 frontCenter; // 0x3FC
	public Vector3 backCenter; // 0x408
	public Vector3 leftCenter; // 0x414
	public Vector3 rightCenter; // 0x420
	public int prefabId; // 0x42C
	public ERCrossingPrefabs prefabScript; // 0x430
	public QDOODOQQDQODD connectionElement; // 0x438
	public int crossingOuterElement; // 0x440
	public string crossingName; // 0x448
	public bool guiChanged; // 0x450
	public bool includeSidewalkChangeFlag; // 0x451
	public List<Vector3> debugVecs; // 0x458
	public List<NormalPairs> normalPairs; // 0x460
	public float maxConnectionWidth; // 0x468
	public int crossingStructure; // 0x46C
	public ERModularBase baseScript; // 0x470
	public List<ERConnectionSibling> siblings1; // 0x478
	public List<ERConnectionSibling> prioritySiblings; // 0x480
	public Vector3 crossPointCenter; // 0x488
	public List<Vector3> edges; // 0x498
	public ERConnectionSibling primaryPriorityConnection; // 0x4A0
	public ERConnectionSibling secondPriorityConnection; // 0x4A8
	public bool adjustMainRadiusFlag; // 0x4B0
	public bool disableAdjustMainRadiusFlag; // 0x4B1
	public bool showScaleSliderAtPrimary; // 0x4B2
	public bool showScaleSliderAtSecondary; // 0x4B3
	public ERRoadWayType priorityWayType; // 0x4B4
	public float leftIntOffset; // 0x4B8
	public float rightIntOffset; // 0x4BC
	public bool isUpdating; // 0x4C0
	public int serializeTest; // 0x4C4
	public int updateQueue; // 0x4C8


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
{	public static readonly ERCrossings.ᙃ <>9; // 0x0
	public static Comparison<ERConnectionSibling> <>9__203_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <OQDOOCDOCD>b__203_0(ERConnectionSibling x, ERConnectionSibling y) { }

}

