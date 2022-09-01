public class ERConnectionSibling // TypeDefIndex: 7192
{
	public string name; 
	public ERModularRoad road; 
	public Transform transform; 
	public Vector3 angleControlPoint; 
	public QDQDOOQQDQODD roadType; 
	public double roadTypeID; 
	public QDQDOOQQDQODD roadTypeAI; 
	public double roadTypeAIid; 
	public bool aIInit; 
	public int roadTypeIndex; 
	public int priorityLevel; 
	public bool priorityRoad; 
	public int prioritySectionStart; 
	public int prioritySectionEnd; 
	public float angle; 
	public float prevAngle; 
	public float roadWidth; 
	public Vector3 controlPoint; 
	public List<Vector2> roadShape; 
	public List<bool> hardEdge; 
	public List<float> roadShapeUVs; 
	public List<bool> originalShapeVecs; 
	public bool includeOuterLaneOffset; 
	public float leftFixedDistance; 
	public float rightFixedDistance; 
	public int buildPriority; 
	public bool highPriorityConnection; 
	public int triangulationType; 
	public bool adjustRadius; 
	public float resolution; 
	public int defaultSegments; 
	public int segments; 
	public float radius; 
	public float leftCornerAngle; 
	public float rightCornerAngle; 
	public Vector3 leftCurvatureDir; 
	public Vector3 leftCurvatureVec; 
	public Vector3 rightCurvatureDir; 
	public Vector3 rightCurvatureVec; 
	public ERFlexConnectionType leftConnectionType; 
	public ERFlexConnectionType rightConnectionType; 
	public Vector3 cp; 
	public Vector3 oldCP; 
	public Vector3 cp1; 
	public Vector3 lStart; 
	public Vector3 lEnd; 
	public Vector3 rStart; 
	public Vector3 rEnd; 
	public Vector3 ip; 
	public Vector3 dir; 
	public Vector3 outerCorner; 
	public float cornerHandleScale; 
	public List<Vector3> leftRoundingPoints; 
	public List<Vector3> rightRoundingPoints; 
	public List<Vector3> innerRoundingPoints; 
	public List<Vector3> priorityLeftPoints; 
	public List<Vector3> priorityRightPoints; 
	public List<Vector3> priorityPointsMain; 
	public List<Vector2> priorityPointsMainUVs; 
	public List<List<Vector3>> roadVecs; 
	public List<List<Vector3>> roadVecsRight; 
	public List<List<Vector3>> roadVecsLeft; 
	public List<List<Vector2>> roadUVs; 
	public List<List<Vector2>> roadUVsLeft; 
	public List<List<Vector2>> roadUVsRight; 
	public List<int> connectionVecInts; 
	public List<float> roadVecPerc; 
	public int leftFixedIndex; 
	public int rightFixedIndex; 
	public int middleIndex; 
	public int middleIndentIndexLeft; 
	public int middleIndentIndexRight; 
	public ERSideWalk leftSidewalk; 
	public ERSideWalk rightSidewalk; 
	public bool leftSidewalkActive; 
	public bool rightSidewalkActive; 
	public List<List<Vector3>> leftSidewalkVecs; 
	public List<List<Vector2>> leftSidewalkUVs; 
	public List<List<Vector3>> rightSidewalkVecs; 
	public List<List<Vector2>> rightSidewalkUVs; 
	public List<Vector3> leftIndentvecs; 
	public List<Vector3> rightIndentvecs; 
	public List<Vector3> leftSurroundingvecs; 
	public List<Vector3> rightSurroundingvecs; 
	public int leftIndent; 
	public int rightIndent; 
	public Vector3 leftIndentV3; 
	public Vector3 rightIndentV3; 
	public int leftSurrounding; 
	public int rightSurrounding; 
	public Vector3 leftSurroundingV3; 
	public Vector3 rightSurroundingV3; 
	public float uvRatio; 
	public float uvy; 
	public int mainRoadConnectionEdgeDecal; 
	public GameObject mainConnectionDecal; 
	public List<Vector3> mainConnectionDecalVecs; 
	public Vector3 mainConnectionDecalEndDir; 
	public int middleInt; 
	public bool primaryPriorityConnection; 
	public bool secondaryPriorityConnection; 
	public bool shapeSubSegments; 
	public List<int> normalIndexes; 
	public bool primarySection; 
	public ERLaneData laneData; 
	public bool hasChanged; 


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

private class ERConnectionSibling.ᙃ : IComparer // TypeDefIndex: 7193
{

	private int System.Collections.IComparer.Compare(object a, object b) { }

	public void .ctor() { }

}

private sealed class ERConnectionSibling.ᙄ // TypeDefIndex: 7194
{
	public static readonly ERConnectionSibling.ᙄ <>9; 
	public static Comparison<ERConnectionSibling> <>9__109_0; 


	private static void .cctor() { }

	public void .ctor() { }

	internal int <CreateInstance>b__109_0(ERConnectionSibling x, ERConnectionSibling y) { }

}

