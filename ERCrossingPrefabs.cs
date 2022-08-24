public class ERCrossingPrefabs : MonoBehaviour // TypeDefIndex: 7179
{
	public List<QDOODOQQDQODD> crossingElements; 
	public List<QDOQDSQOOQDDD> sidewalkControlElements; 
	public List<ERConnectionSibling> siblings; 
	public Vector3[] meshVecs; 
	public Vector3[] fullMeshVecs; 
	public Vector3[] tmpMeshVecs; 
	public Vector3[] tmpFullMeshVecs; 
	public Vector3[] tCrossingTmpFullMeshVecs; 
	public int[] outerVecInts; 
	public List<Vector3> surfaceVecs; 
	public List<int> surfaceVecType; 
	public List<int> surfaceConnectionInt; 
	public List<ERBlendVecs> tCrossingBlendData; 
	public List<Vector3> indentVecs; 
	public GameObject sourcePrefab; 
	public int prefabId; 
	public string guid; 
	public List<int> prioritySegments; 
	public float minNodeDistance; 
	public int nodeWithinRange; 
	public GameObject sourceObject; 
	public bool meshInstance; 
	public int selectedConnection; 
	public string[] QDOOOQOOQQQQD; 
	public bool deformTerrain; 
	public bool isRoundabout; 
	public bool isERCrossing; 
	public bool isYConnector; 
	public bool isIConnector; 
	public bool isFlexConnector; 
	public bool isSnapConnector; 
	public bool isExitRoadConnector; 
	public Vector3 prefabCenterDummy; 
	public float snapRadius; 
	public ERRoundabouts roundaboutScript; 
	public ERCrossings crossingsScript; 
	public ERIConnector iConnectorScript; 
	public bool isCustomPrefab; 
	public int customPrefabVersion; 
	public bool recalculateNormals; 
	public bool planarUVs; 
	public float planarTiling; 
	public int lastVecRoadIndex; 
	public bool isSceneObject; 
	public GameObject surfaceObject; 
	public Vector3[] surfaceMeshVecs; 
	public Vector3[] tmpSurfaceMeshVecs; 
	public Vector3[] tmpSurfaceVecsTCrossings; 
	public int[] surfaceInts; 
	public Vector3 leftBottomCorner; 
	public Vector3 leftTopCorner; 
	public Vector3 rightBottomCorner; 
	public Vector3 rightTopCorner; 
	public bool tCrossing; 
	public bool tStraightBending; 
	public int tCrossingLeftRight; 
	public float tMainRoadWidth; 
	public float tConnectionRoadWidth; 
	public float bottomLeftSidewalkWidth; 
	public float bottomLeftSidewalkOuterOffset; 
	public float bottomLeftSidewalkCurbDepth; 
	public float bottomRightSidewalkWidth; 
	public float bottomRightSidewalkOuterOffset; 
	public float bottomRightSidewalkCurbDepth; 
	public float topLeftSidewalkWidth; 
	public float topLeftSidewalkOuterOffset; 
	public float topLeftSidewalkCurbDepth; 
	public float topRightSidewalkWidth; 
	public float topRightSidewalkOuterOffset; 
	public float topRightSidewalkCurbDepth; 
	public ERConnection connObject; 
	public Vector3 testVec; 
	public List<int> surfaceSurroundingInts; 
	public int rotationPriorityElement; 
	public Vector3 cornerPos; 
	public Vector3 mainCorner; 
	public Vector3 connectedCorner; 
	public Vector3 mainVecOuter; 
	public Vector3 connectionVecOuter; 
	public Vector3 indentTopVec; 
	public Vector3 indentRightVec; 
	public Vector3 mainIndent; 
	public Vector3 connectionIndent; 
	public int selectedRotationConnection; 
	public Vector3 bottomVec; 
	public Vector3 rightVec; 
	public Vector3 bottomIndent; 
	public Vector3 rightIndent; 
	public float sAngle; 
	public ERModularBase baseScript; 
	public bool QDQDQOOQQDQOQQ; 
	public Vector3 tp1; 
	public Vector3 tp2; 
	public bool doTerrainDeformation; 
	public bool includeOuterVertices; 
	public bool averageNormals; 
	public float surroundingDistance; 
	public Mesh surfaceMesh; 
	public List<Vector3> debugVecs1; 
	public List<Vector3> debugVecs2; 
	public bool lightmapAdjusted; 
	public bool isFlexUpdating; 
	public Vector3 oldPosition; 
	public Vector3 oldRotation; 
	public bool lockScale; 
	public float extraIndentMargin; 
	public float indent; 
	public float surrounding; 


public void OCOODQQDQO() { }

public void OOCQCCQDOQ(Vector3 v1, Vector3 v2, int connectionElement, ERModularRoad road) { }

public void OCQDDQODCC(int el) { }

public void OCDOCCODOC(int elInt, float distance) { }

public void DeformTCossingConnection(int elInt, float distance, float defaultDistance, List<Vector3> controlPoints, float multiplyFactor, float angle, Vector3 cpCenterPoint, float curveStrength) { }

public void OOODCOOOCQ(List<int> affectedVecs, List<Vector2> tmpVecs) { }

public void OQOQDDOCDC(bool ignorePriority, ERModularRoad road) { }

public void OQQODODQCQ() { }

public void OQQCDODDQQ(bool forceFlag) { }

public void CheckPlanarUVs() { }

public static bool OOCCOODCOO(List<ERModularRoad> affectedObjects, ERModularRoad roadScr) { }

public void OCCDCDDOOQ(bool flag) { }

public void OODODQQCOD(int el) { }

public bool HasConnections() { }

public bool HasConnectionsFull() { }

public void OOQOQQODCD() { }

public void OCODDQDQCC(int el, int startend) { }

public void PopulateSiblingsList() { }

public void InitFlexConnector() { }

public void AttachRoadToFlexConnector(ERModularBase scr, float OCCDOQCODC, Vector3 OCCQOCQOQD) { }

public void OQQQQOOCDO(int index) { }

public void SetElementInfo(int index, int sourceIndex) { }

public static void ODDQDDQOOD() { }

public static bool OQCDCDOOCD(Vector3 pTarget, Vector3 pSource, Vector3 pCheck) { }

public void .ctor() { }

}

