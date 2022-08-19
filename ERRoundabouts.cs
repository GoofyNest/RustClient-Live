public class ERRoundabouts : MonoBehaviour // TypeDefIndex: 7175
{	// Fields
	public float roundAboutRadius; // 0x18
	public float prevRoundAboutRadius; // 0x1C
	public float roundAboutResolution; // 0x20
	public float prevRoundAboutResolution; // 0x24
	public float rDist; // 0x28
	public Vector3 raStartPos; // 0x2C
	public float roundaboutWidth; // 0x38
	public float prevRoundaboutWidth; // 0x3C
	public int roadTypeInt; // 0x40
	public int prevRoadTypeInt; // 0x44
	public float roadWidth; // 0x48
	public float prevRoadWidth; // 0x4C
	public bool lockLeftRightRoundingRadius; // 0x50
	public float leftRoundingRadius; // 0x54
	public float prevLeftRoundingRadius; // 0x58
	public float rightRoundingRadius; // 0x5C
	public float prevRightRoundingRadius; // 0x60
	public int roundingSegments; // 0x64
	public float connectionLength; // 0x68
	public float maxRoadWidth; // 0x6C
	public float maxRoundingRadius; // 0x70
	public List<Vector3> meshVecs; // 0x78
	public List<Vector3> mainRightPoints; // 0x80
	public List<Vector3> mainCenterPoints; // 0x88
	public List<Vector3> mainLeftPoints; // 0x90
	public List<Vector3> OCCDQOCCDQ; // 0x98
	public List<Vector2> mainRightPointsUVs; // 0xA0
	public List<Vector2> mainCenterPointsUVs; // 0xA8
	public List<Vector2> mainLeftPointsUVs; // 0xB0
	public List<Vector2> OCCDQOCCDQUVs; // 0xB8
	public List<Vector3> innerRoundaboutSidewalkV3; // 0xC0
	public List<Vector2> innerRoundaboutSidewalUV; // 0xC8
	public List<int> innerRoundaboutSidewalTris; // 0xD0
	public Material innerRoundaboutSidewalkMaterial; // 0xD8
	public List<int> innerRoundaboutSidewalkIntsStart; // 0xE0
	public List<int> innerRoundaboutSidewalkIntsEnd; // 0xE8
	public int innerSidewalkSegments; // 0xF0
	public Vector3 leftPoint; // 0xF4
	public Vector3 leftPoint1; // 0x100
	public Vector3 rightPoint; // 0x10C
	public Vector3 rightPoint1; // 0x118
	public Vector3 centerOnLine; // 0x124
	public Vector3 leftOuterPoint; // 0x130
	public Vector3 rightOuterPoint; // 0x13C
	public Vector3 pl; // 0x148
	public Vector3 pr; // 0x154
	public List<Vector3> edgePoints; // 0x160
	public int newSegmentInt; // 0x168
	public int prevNewSegmentInt; // 0x16C
	public List<ERRoundaboutElement> connections; // 0x170
	public string[] QDOOOQOOQQQQD; // 0x178
	public int selectedConnection; // 0x180
	public int activeConnection; // 0x184
	public int tmpSelectedConnection; // 0x188
	public int minStartInt; // 0x18C
	public int maxEndInt; // 0x190
	public int centerInt; // 0x194
	public int leftOuterInt; // 0x198
	public int rightOuterInt; // 0x19C
	public List<Vector3> leftOuterSegments; // 0x1A0
	public List<Vector3> leftInnerSegments; // 0x1A8
	public List<Vector3> rightOuterSegments; // 0x1B0
	public List<Vector3> rightInnerSegments; // 0x1B8
	public List<Vector2> leftOuterSegmentsUVs; // 0x1C0
	public List<Vector2> leftInnerSegmentsUVs; // 0x1C8
	public List<Vector2> rightOuterSegmentsUVs; // 0x1D0
	public List<Vector2> rightInnerSegmentsUVs; // 0x1D8
	public Vector3 outerCenterPoint; // 0x1E0
	public bool blendFlag; // 0x1EC
	public Material mainRoadMaterial; // 0x1F0
	public Material roadMaterial; // 0x1F8
	public Material connectionMaterial; // 0x200
	public Material defaultConnectionMaterial; // 0x208
	public double roadType; // 0x210
	public double roadTypeTimestamp; // 0x218
	public List<Vector3> innerRoundaboutPoints; // 0x220
	public List<Vector2> innerRoundaboutUVs; // 0x228
	public float innerSegmentDistance; // 0x230
	public float innerSidewalkWidth1; // 0x234
	public float innerSidewalkWidth2; // 0x238
	public float innerCurbHeight; // 0x23C
	public float innerCurbDepth; // 0x240
	public bool innerBeveledCurb; // 0x244
	public float innerBeveledHeight; // 0x248
	public float innerBeveledDepth; // 0x24C
	public bool innerOuterCurb; // 0x250
	public bool innerRoadSideCurbUVControl; // 0x251
	public bool innerOuterSideCurbUVControl; // 0x252
	public Material innerSidewalkMaterial; // 0x258
	public List<float> innerSidewalkUVs; // 0x260
	public List<float> innerCurbUVs; // 0x268
	public int selectedCorner; // 0x270
	public int selectedCornerPreset; // 0x274
	public int selectedSidewalkPreset; // 0x278
	public string sidewalkPresetName; // 0x280
	public int innerRoundaboutPreset; // 0x288
	public bool leftFlag; // 0x28C
	public bool rightFlag; // 0x28D
	private bool ᙃ; // 0x28E
	public ERCrossingPrefabs prefabScript; // 0x290
	public QDOODOQQDQODD connectionElement; // 0x298
	public ERModularBase baseScript; // 0x2A0
	public bool isSceneObject; // 0x2A8
	public bool guiChanged; // 0x2A9
	public string crossingName; // 0x2B0
	public bool activeSidewalks; // 0x2B8
	public bool newConnectionFlag; // 0x2B9
	public Vector3 testIndentMiddlePoint; // 0x2BC
	public List<QDQDOOQQDQODD> roadTypesDynamic; // 0x2C8

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0xB569F0 Offset: 0xB55DF0 VA: 0x180B569F0
	public bool UpdateToRoadType(QDQDOOQQDQODD sourcePreset) { }

	// RVA: 0xB564B0 Offset: 0xB558B0 VA: 0x180B564B0
	public void ResetData() { }

	// RVA: 0xB4EDE0 Offset: 0xB4E1E0 VA: 0x180B4EDE0
	public void ODQDCCOQOD() { }

	// RVA: 0xB51880 Offset: 0xB50C80 VA: 0x180B51880
	public void OOQQDCCCCC() { }

	// RVA: 0xB47C90 Offset: 0xB47090 VA: 0x180B47C90
	public void GetConnectionData() { }

	// RVA: 0xB56830 Offset: 0xB55C30 VA: 0x180B56830
	public void UpdateMinMaxInts() { }

	// RVA: 0xB47B30 Offset: 0xB46F30 VA: 0x180B47B30
	public void ChecknewSegmentInt() { }

	// RVA: 0xB483A0 Offset: 0xB477A0 VA: 0x180B483A0
	public int GetRoadPresetInt(double id) { }

	// RVA: 0xB48D70 Offset: 0xB48170 VA: 0x180B48D70
	public void OCQCQODOQC(ERRoundabouts source, bool refreshFlag) { }

	// RVA: 0xB48550 Offset: 0xB47950 VA: 0x180B48550
	public void OCDCOQOOQO() { }

	// RVA: 0xB4C8A0 Offset: 0xB4BCA0 VA: 0x180B4C8A0
	public void ODCDCDDOCC(List<SidewalkPresetClass> sidewalkPresets, int el) { }

	// RVA: 0xB507D0 Offset: 0xB4FBD0 VA: 0x180B507D0
	public void OOCDDOQDDO() { }

	// RVA: 0xB54620 Offset: 0xB53A20 VA: 0x180B54620
	public void OQQCDOQOOQ() { }

	// RVA: 0xB51CF0 Offset: 0xB510F0 VA: 0x180B51CF0
	public void OQCQDQDCOD(int currentIndex) { }

	// RVA: 0xB54CB0 Offset: 0xB540B0 VA: 0x180B54CB0
	public void OQQOCQQDOQ(ref List<Vector3> OCCDQOCCDQ, ref List<Vector3> innerSegmentPoints, int leftRight, int startElement, Vector3 leftPoint, Vector3 rightPoint, Vector3 forward, int currentIndex) { }

	// RVA: 0xB4F900 Offset: 0xB4ED00 VA: 0x180B4F900
	public void OOCCDCDOQC(int currentIndex) { }

	// RVA: 0xB4D020 Offset: 0xB4C420 VA: 0x180B4D020
	public void ODDDOCDCQO() { }

	// RVA: 0xB53F20 Offset: 0xB53320 VA: 0x180B53F20
	public void OQCQQCQDCQ(int el, List<int> trIntArray, List<float> uvArray, List<List<int>> leftSidewalkIntArray, List<List<int>> rightSidewalkIntArray, int startend) { }

	// RVA: 0xB48600 Offset: 0xB47A00 VA: 0x180B48600
	public void OCDDOCDDOQ(List<Vector3> meshVecs, List<int> connectionVecInts, ref List<Vector2> roadShapeVecs, List<Vector2> vecArrays, List<List<Vector3>> leftSidewalkArray, List<List<Vector3>> rightSidewalkArray, int connectionElement, int startend) { }

	// RVA: 0xB4E8E0 Offset: 0xB4DCE0 VA: 0x180B4E8E0
	public void ODQCODQDDQ(int el, Material roadMaterial, int leftVecCount, int rightVecCount) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public void ODCQOCOOQO() { }

	// RVA: 0xB4AD50 Offset: 0xB4A150 VA: 0x180B4AD50
	public void OCQOCDQQQD(int el) { }

	// RVA: 0xB54A20 Offset: 0xB53E20 VA: 0x180B54A20
	public static bool OQQCODDOOQ(int el, float roundaboutIndent, Vector3 prevVec, bool boolCheck, ref Vector3 vec, ref int indentBorderInt) { }

	// RVA: 0xB4F5B0 Offset: 0xB4E9B0 VA: 0x180B4F5B0
	public void ODQOOCQDDD(float minSurrounding, Vector3 middleVec, Vector3 origVec, bool boolCheck, ref Vector3 vec) { }

	// RVA: 0xB47AA0 Offset: 0xB46EA0 VA: 0x180B47AA0
	public void CheckAgainstFirstSurroundingVec(Vector3 firstIndent, Vector3 firstSurrounding, bool boolCheck, ref Vector3 vec) { }

	// RVA: 0xB516B0 Offset: 0xB50AB0 VA: 0x180B516B0
	public static Vector3 OODOQDOODO(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4) { }

	// RVA: 0xB544C0 Offset: 0xB538C0 VA: 0x180B544C0
	public static Vector3 OQDDDODCOC(Vector3 point, Vector3 pivot, Quaternion angle) { }

	// RVA: 0xB57350 Offset: 0xB56750 VA: 0x180B57350
	public void .ctor() { }

}

