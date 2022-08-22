public class ERConnectionSibling // TypeDefIndex: 7191
{	public string name; // 0x10
	public ERModularRoad road; // 0x18
	public Transform transform; // 0x20
	public Vector3 angleControlPoint; // 0x28
	public QDQDOOQQDQODD roadType; // 0x38
	public double roadTypeID; // 0x40
	public QDQDOOQQDQODD roadTypeAI; // 0x48
	public double roadTypeAIid; // 0x50
	public bool aIInit; // 0x58
	public int roadTypeIndex; // 0x5C
	public int priorityLevel; // 0x60
	public bool priorityRoad; // 0x64
	public int prioritySectionStart; // 0x68
	public int prioritySectionEnd; // 0x6C
	public float angle; // 0x70
	public float prevAngle; // 0x74
	public float roadWidth; // 0x78
	public Vector3 controlPoint; // 0x7C
	public List<Vector2> roadShape; // 0x88
	public List<bool> hardEdge; // 0x90
	public List<float> roadShapeUVs; // 0x98
	public List<bool> originalShapeVecs; // 0xA0
	public bool includeOuterLaneOffset; // 0xA8
	public float leftFixedDistance; // 0xAC
	public float rightFixedDistance; // 0xB0
	public int buildPriority; // 0xB4
	public bool highPriorityConnection; // 0xB8
	public int triangulationType; // 0xBC
	public bool adjustRadius; // 0xC0
	public float resolution; // 0xC4
	public int defaultSegments; // 0xC8
	public int segments; // 0xCC
	public float radius; // 0xD0
	public float leftCornerAngle; // 0xD4
	public float rightCornerAngle; // 0xD8
	public Vector3 leftCurvatureDir; // 0xDC
	public Vector3 leftCurvatureVec; // 0xE8
	public Vector3 rightCurvatureDir; // 0xF4
	public Vector3 rightCurvatureVec; // 0x100
	public ERFlexConnectionType leftConnectionType; // 0x10C
	public ERFlexConnectionType rightConnectionType; // 0x110
	public Vector3 cp; // 0x114
	public Vector3 oldCP; // 0x120
	public Vector3 cp1; // 0x12C
	public Vector3 lStart; // 0x138
	public Vector3 lEnd; // 0x144
	public Vector3 rStart; // 0x150
	public Vector3 rEnd; // 0x15C
	public Vector3 ip; // 0x168
	public Vector3 dir; // 0x174
	public Vector3 outerCorner; // 0x180
	public float cornerHandleScale; // 0x18C
	public List<Vector3> leftRoundingPoints; // 0x190
	public List<Vector3> rightRoundingPoints; // 0x198
	public List<Vector3> innerRoundingPoints; // 0x1A0
	public List<Vector3> priorityLeftPoints; // 0x1A8
	public List<Vector3> priorityRightPoints; // 0x1B0
	public List<Vector3> priorityPointsMain; // 0x1B8
	public List<Vector2> priorityPointsMainUVs; // 0x1C0
	public List<List<Vector3>> roadVecs; // 0x1C8
	public List<List<Vector3>> roadVecsRight; // 0x1D0
	public List<List<Vector3>> roadVecsLeft; // 0x1D8
	public List<List<Vector2>> roadUVs; // 0x1E0
	public List<List<Vector2>> roadUVsLeft; // 0x1E8
	public List<List<Vector2>> roadUVsRight; // 0x1F0
	public List<int> connectionVecInts; // 0x1F8
	public List<float> roadVecPerc; // 0x200
	public int leftFixedIndex; // 0x208
	public int rightFixedIndex; // 0x20C
	public int middleIndex; // 0x210
	public int middleIndentIndexLeft; // 0x214
	public int middleIndentIndexRight; // 0x218
	public ERSideWalk leftSidewalk; // 0x220
	public ERSideWalk rightSidewalk; // 0x228
	public bool leftSidewalkActive; // 0x230
	public bool rightSidewalkActive; // 0x231
	public List<List<Vector3>> leftSidewalkVecs; // 0x238
	public List<List<Vector2>> leftSidewalkUVs; // 0x240
	public List<List<Vector3>> rightSidewalkVecs; // 0x248
	public List<List<Vector2>> rightSidewalkUVs; // 0x250
	public List<Vector3> leftIndentvecs; // 0x258
	public List<Vector3> rightIndentvecs; // 0x260
	public List<Vector3> leftSurroundingvecs; // 0x268
	public List<Vector3> rightSurroundingvecs; // 0x270
	public int leftIndent; // 0x278
	public int rightIndent; // 0x27C
	public Vector3 leftIndentV3; // 0x280
	public Vector3 rightIndentV3; // 0x28C
	public int leftSurrounding; // 0x298
	public int rightSurrounding; // 0x29C
	public Vector3 leftSurroundingV3; // 0x2A0
	public Vector3 rightSurroundingV3; // 0x2AC
	public float uvRatio; // 0x2B8
	public float uvy; // 0x2BC
	public int mainRoadConnectionEdgeDecal; // 0x2C0
	public GameObject mainConnectionDecal; // 0x2C8
	public List<Vector3> mainConnectionDecalVecs; // 0x2D0
	public Vector3 mainConnectionDecalEndDir; // 0x2D8
	public int middleInt; // 0x2E4
	public bool primaryPriorityConnection; // 0x2E8
	public bool secondaryPriorityConnection; // 0x2E9
	public bool shapeSubSegments; // 0x2EA
	public List<int> normalIndexes; // 0x2F0
	public bool primarySection; // 0x2F8
	public ERLaneData laneData; // 0x300
	public bool hasChanged; // 0x308


	public void Clear() { }

	private void Init(ERModularRoad scr, float angle, Vector3 controlPoint, Transform transform) { }

	public static ERConnectionSibling CreateInstance(ERModularRoad scr, float angle, Vector3 controlPoint, Transform transform, List<ERConnectionSibling> siblings) { }

	private void GetRoadTypeIndex(double id, List<QDQDOOQQDQODD> types) { }

	public void ODDQDOCDCC(int index, List<QDQDOOQQDQODD> types) { }

	public void OCQQDCCOQO(List<QDQDOOQQDQODD> types) { }

	private void BuildRoadShape() { }

	public static void SetPriorityConnection(List<ERConnectionSibling> siblings, int index) { }

	public Vector2 GetVector2(Vector2 v1, Vector2 v2, Vector2 v3) { }

	public void OCQODDOQQC(double type, List<QDQDOOQQDQODD> roadTypes) { }

	public static Vector3 GetAngleControlPoint(Vector3 cp, Vector3 p0, Vector3 p1, Vector3 p2) { }

	public void .ctor() { }

}

private class ERConnectionSibling.ᙃ : IComparer // TypeDefIndex: 7192
{
	private int System.Collections.IComparer.Compare(object a, object b) { }

	public void .ctor() { }

}

private sealed class ERConnectionSibling.ᙄ // TypeDefIndex: 7193
{	public static readonly ERConnectionSibling.ᙄ <>9; // 0x0
	public static Comparison<ERConnectionSibling> <>9__109_0; // 0x8


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CreateInstance>b__109_0(ERConnectionSibling x, ERConnectionSibling y) { }

}

