public class ERModularRoad : MonoBehaviour // TypeDefIndex: 7179
{
	public ERModularBase baseScript; 
	public string roadName; 
	public bool locked; 
	public double roadType; 
	public QDQDOOQQDQODD rt; 
	public int defaultControlType; 
	public bool isCustomRoadSet; 
	public bool isCustomRoad; 
	public List<ERMarker> markers; 
	public List<ERMarker> tmpMarkers; 
	public List<ERMarkerExt> markersExt; 
	public List<ERMarkerExt> tmpMarkersExt; 
	public List<float> tValues; 
	public float roadWidth; 
	public float faceDistance; 
	public float angleTreshold; 
	public bool resolutionFlag; 
	public bool angleThresholdFlag; 
	public bool closedTrack; 
	public float minNodeDistance; 
	public int nodeWithinRange; 
	public float uvTiling; 
	public bool planarUVs; 
	public bool flipNormals; 
	public int defaultLeftSidewalk; 
	public int defaultRightSidewalk; 
	public bool leftSidewalkActive; 
	public bool rightSidewalkActive; 
	public List<ERSideWalkInstance> leftSidewalks; 
	public List<ERSideWalkInstance> rightSidewalks; 
	public List<OQQCCQCDQQ> exitRoads; 
	public int selectedExit; 
	public bool randomnessFlag; 
	public bool randomnessMarkerFlag; 
	public float randomYPosition; 
	public float randomMinYPosition; 
	public float randomMaxYPosition; 
	public float minRandomYPositionDistance; 
	public float maxRandomYPositionDistance; 
	public float randomMinRotation; 
	public float randomMaxRotation; 
	public float minRandomRotationDistance; 
	public float maxRandomRotationDistance; 
	public bool vegetationStudioMaskLineActive; 
	public float vegetationStudioGrassPerimeter; 
	public float vegetationStudioPlantPerimeter; 
	public float vegetationStudioTreePerimeter; 
	public float vegetationStudioObjectPerimeter; 
	public float vegetationStudioLargeObjectPerimeter; 
	public bool vegetationStudioBiomeMaskActive; 
	public float vegetationStudioBiomeMaskDistance; 
	public float vegetationStudioBiomeMaskBlendDistance; 
	public float vegetationStudioBiomeMaskNoiseScale; 
	public int vertsStats; 
	public int trisStats; 
	public float indent; 
	public float surrounding; 
	public bool followTerrainContours; 
	public float terrainContoursOffset; 
	public List<Vector2> roadShape; 
	public List<int> roadShapeIntsStart; 
	public List<int> roadShapeIntsEnd; 
	public List<int> roadShapeIntsStartFull; 
	public List<int> roadShapeIntsEndFull; 
	public string roadShapeString; 
	public string roadShapeReversedString; 
	public int roadShapeMatchCount; 
	public int geoReversed; 
	public int roadShapeCols; 
	public bool flipRoadUVs; 
	public int subSegments; 
	public List<float> nodeDistance; 
	public List<float> roadShapeUVs; 
	public List<float> roadShapeUVs2; 
	public List<bool> doConnectionTri; 
	public List<float> randomRotations; 
	public List<bool> hardEdge; 
	public List<int> roadShapeMaterialInts; 
	public int subMeshCount; 
	public List<int> roadShapeMaterialIntCounts; 
	public List<Vector3> controlPoints; 
	public List<Vector3> splinePoints; 
	public List<float> distances; 
	public List<int> markerInts; 
	public List<Vector3> insertSplinePoints; 
	public List<Vector3> soSplinePoints; 
	public List<Vector3> soSplinePointsLeft; 
	public List<Vector3> soSplinePointsRight; 
	public List<Vector3> soSplinePointsLeftClamped; 
	public List<Vector3> soSplinePointsRightClamped; 
	public List<float> OQCOCCQCCD; 
	public List<float> OQQOODQCCC; 
	public List<float> bendAngles; 
	public List<Vector3> meshVecs; 
	public List<Vector2> meshUVs; 
	public List<Vector2> meshUVs2; 
	public List<List<int>> tris; 
	public List<Vector3> surfaceMeshVecs; 
	public List<Vector3> leftIndentVecs; 
	public List<Vector3> rightIndentVecs; 
	public List<Vector3> middleIndentVecs; 
	public List<Vector3> leftSurroundingVecs; 
	public List<Vector3> rightSurroundingVecs; 
	public List<Vector3> leftIndentVecsSV; 
	public List<Vector3> rightIndentVecsSV; 
	public List<bool> bridgeElement; 
	public List<Vector3> vecsBelowTerrain; 
	public List<Vector3> treeVecs; 
	public List<Vector3> detailVecs; 
	public List<int> vegetationTris; 
	public List<bool> doLeftSurrounding; 
	public List<bool> doRightSurrounding; 
	public float totalDistance; 
	public List<int> nodeSplinePoint; 
	public string totalDistanceString; 
	public ERCrossingPrefabs startPrefabScript; 
	public ERCrossingPrefabs endPrefabScript; 
	public int startConnectionSegment; 
	public bool startConnectionFlag; 
	public int endConnectionSegment; 
	public bool endConnectionFlag; 
	public bool startSegmentIntAdjusted; 
	public bool endSegmentIntAdjusted; 
	public bool tCrossingConnected; 
	public Material roadMaterial; 
	public Material[] roadMaterials; 
	public PhysicMaterial roadPhysicsMaterial; 
	public PhysicMaterial[] roadPhysicsMaterials; 
	public Vector3 startDir; 
	public Vector3 endDir; 
	public float startAngle; 
	public float endAngle; 
	private int ᙃ; 
	private int ᙄ; 
	public int startbendLeftRight; 
	public int endbendLeftRight; 
	public float connectionAdjustDistanceStart; 
	public float connectionAdjustDistanceEnd; 
	public Vector3 pivotp; 
	public Vector3 p1; 
	public Vector3 p2; 
	public Vector3 p3; 
	public Vector3 p4; 
	public Vector3 p5; 
	public Vector3 p6; 
	public Vector3 p7; 
	public Vector3 cp1; 
	public Vector3 cp2; 
	public Vector3 cp3; 
	public Vector3 cp4; 
	public Vector3 cp5; 
	public Vector3 cp6; 
	public Vector3 cp7; 
	public Vector3 cp8; 
	public Vector3 cp9; 
	public Vector3 cpcenter; 
	public Vector3 p1Circle; 
	public Vector3 p2Circle; 
	public float cpradius; 
	public float cpangle; 
	public Vector3 dp1; 
	public Vector3 dp2; 
	public Vector3 dp3; 
	public Vector3 dp4; 
	public List<Vector3> segPoints; 
	public List<Vector3> testPoints; 
	public List<Vector3> testPoints2; 
	public Vector3 OQOQODDQCC; 
	public Vector3 ODQCDQCCOD; 
	public Vector3 endLeft; 
	public Vector3 endRight; 
	public Mesh testmesh; 
	public GameObject surfaceMesh; 
	public Vector3 sv1; 
	public Vector3 sv2; 
	public Vector3 prefabIndentLeft; 
	public Vector3 prefabIndentRight; 
	public Vector3 roadIndent1; 
	public static int ODQQCDOQOD; 
	public static int OCOQCCDDQC; 
	public static int ODCDCCQCQC; 
	public static int OQDCDCOCQC; 
	public static int OQQQOQOQOQ; 
	public static int OQOQDOCQCD; 
	public Vector3 tmpPerpCP; 
	public Vector3 tmpCP; 
	private int ᙅ; 
	private int 4AAAA; 
	public float splinePos; 
	public float camHeight; 
	public Vector3[] flyOverPoints; 
	public Vector3 splinePosV3; 
	public List<float> markerDistances; 
	public string osmRoadType; 
	public List<ERSORoad> soData; 
	public List<ERSORoadExt> soDataExt; 
	public string[] sideObjectNames; 
	public int selectedSO; 
	public bool rebuildSos; 
	public bool sosCleared; 
	public bool isSideObject; 
	public int startOffsetActiveMarker; 
	public int endOffsetActiveMarker; 
	public float leftToCenterPerc; 
	public ERRoad road; 
	public bool splatMapActive; 
	public int splatIndex; 
	public int expandLevel; 
	public int smoothLevel; 
	public float splatOpacity; 
	public int layer; 
	public bool isStatic; 
	public string tag; 
	public int tagInt; 
	public bool castShadow; 
	public bool fadeInFlag; 
	public float fadeInDistance; 
	public bool fadeOutFlag; 
	public float fadeOutDistance; 
	public bool doSurroundingSurfaces; 
	public bool terrainDeformation; 
	public bool snapToTerrain; 
	public List<ERSOSection> soSectionList1; 
	public List<ERSOSection> soSectionList2; 
	public List<ERSOSection> soSectionList3; 
	public List<ERSOSection> soSectionList4; 
	public List<ERSOSection> soSectionList5; 
	public List<ERSOSection> soSectionList6; 
	public List<ERSOSection> soSectionList7; 
	public List<ERSOSection> soSectionList8; 
	public bool snapVertices; 
	public float snapOffset; 
	public bool hasMeshCollider; 
	public bool isUpdated; 
	public bool QDDDQODQQDQDQQD; 
	public int uv4Type; 
	public float detailDistance; 
	public bool startDecalCollapsed; 
	public ERDecal startDecal; 
	public ERDecal endDecal; 
	public GameObject startDecalPrefab; 
	public GameObject startDecalPrefabSource; 
	public bool endDecalCollapsed; 
	public GameObject endDecalPrefab; 
	public GameObject endDecalPrefabSource; 
	public int startDecalID; 
	public int endDecalID; 
	public Vector3 lastForward; 
	public bool roadUpdate; 
	public Bounds bounds; 
	public List<Vector3> debugVecs; 
	public List<float> debugFloats; 
	public Vector3 exitExtrudeEnd; 
	public Vector3 exitFixedEnd; 
	public Vector3 exitSplitEnd; 
	public Texture2D splatTextureMask; 
	public bool lockUVs; 
	public List<ERLaneData> laneData; 
	public bool oneWayRoad; 
	public ERLaneDirection oneWayDirection; 


	public bool ODDQCOCDQQ(ERCrossingPrefabs prefabScript) { }

	public void ODQCQCDCDQ(List<ERDecal> decalPresets) { }

	public void OOQOCCOOOD() { }

	public float GetRoadWidth() { }

	public void OQQOCOQDCQ(Vector3 pos) { }

	public int OCDQCCCDCC(Vector3 pos) { }

	public void GetInsertPointExt(Vector3 pos, ref int n1, int marker) { }

	public void OCOOCCODDD(Vector3 pos, ref int n1) { }

	public void OOODDDDQQO(Vector3 pos, ref int n1, int selectedMarker, bool sameRoad) { }

	public int OQCCQDDOQD(Vector3 pos) { }

	public int OOCDODCOOD(Vector3 pos, int selectedMarker) { }

	public int HandleAddMarkerAtStart(Vector3 pos, int selectedMarker) { }

	public void ODDDCDQCCO(ERCrossingPrefabs ODCQDOOOCC, int targetElement, bool reverse, bool uvReverse, bool UpdateResolutionFlag) { }

	public void OOOCDCQQCO(bool ignorePrefabAlignment, int selectedMarker) { }

	public void PrintRoadShape(List<Vector2> lst) { }

	public void OCQOQCDCQC(bool ignorePrefabAlignment, bool forceAutoRotate) { }

	private void OCODCOOQOC(ref List<Vector3> vecs, ref List<Vector2> uvs, ref List<Vector2> uvs2, int cols, ref int addedRows, ref List<bool> isPlanar, ref List<Color> colors, ref float uv, ref float uv4) { }

	public void OCDCOOQOQD(Mesh m) { }

	public void OQOOOOOOCQ(ERDecal decal, ref GameObject decalPrefab, string name) { }

	public float ODCDOQOOOO(ERDecal decal, float roadWidth) { }

	public void OOOCOODQCO(string type) { }

	public void OQOCCDCCDD(GameObject decal, int index) { }

	public float OCDDDDQDQQ(int startEnd) { }

	public Vector3[] AdjustNormals(Vector3[] normals) { }

	public void AdjustPrefabNormals(List<int> roadInts, List<int> prefabInts, Vector3[] normals, GameObject prefab, Vector3[] verts) { }

	public bool OQCDCDOOCD(Vector3 pTarget, Vector3 pSource, Vector3 pCheck) { }

	public void OODCOQOQOD(ref List<Vector3> surfaceVecs, ERCrossingPrefabs prefabScript, ref bool startSurfacesSafe, float distance, float minIndent) { }

	public void ODOCCQDCQO(ref List<Vector3> surfaceVecs, ERCrossingPrefabs prefabScript, int el, ref bool surfacesSafe, float distance, float minIndent) { }

	public bool OQCODQODCO(Vector3 ODCQDOOOCCIndent, Vector3 otherPrefabIndent, Vector3 v) { }

	public void OCQOQQCDOD(List<Vector3> surfaceVecs, List<Vector2> uvs, int h, List<bool> doBridge, Vector3 firstDir, Vector3 lastDir, float indent, float surrounding, List<bool> tunnelSegments) { }

	public void InterpolateSurfaces(ref List<Vector3> surfaceVecs, ref List<Vector2> uvs, ref List<int> tris, Vector3 dir, int vecCount, int startEnd, float indent, float surrounding) { }

	public void OOCCDCDCQD() { }

	public List<Vector3> OQDDOOOOQD(List<ERMarkerExt> markersExt, float faceDist, bool ignorePrefabAlignment, ref List<float> tValues, ref List<float> markerDistances, bool forceAutoRotate, ref List<float> rotationArray, ref List<float> bendAngles) { }

	public void OCQOOCCQDD(List<ERMarkerExt> tmpMarkers, int j, Vector3[] tr, Vector3 circleDir, float totalDist, ref Vector3 startCP, int startMarker, List<Vector3> p) { }

	public void OQDOQOCDDQ(List<ERMarkerExt> tmpMarkersExt, int j, Vector3[] tr, ref Vector3 endCP, int startMarker) { }

	public void OOCCQCCDQC(ref Vector3 endCP, Vector3 curV3, Vector3 nextV3, Vector3 nextNextV3) { }

	public List<float> OQDOOOQODD(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, ref List<float> OQQOODQCCC, List<float> randomRotations) { }

	public void RoadSmoothness(float curDist, ERMarkerExt marker, float totalDistance, ref float randomYDistanceStart, ref float randomYDistanceEnd, ref float randomYDistanceMiddle, ref Vector3 randomYDistanceV3, ref Vector3 v, ref float currentRandomYDistance, ref float randomRotationStart, ref float randomRotationEnd, ref float randomRotationMiddle, ref Vector3 randomRotationV3, ref float currentRandomRotation, ref List<float> rotationArray) { }

	public List<List<Vector2>> GetRoadShapeValues(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, List<Vector2> roadShape) { }

	public List<float> GetSurfaceValues(List<float> tValues, List<float> markerDistances, List<ERMarkerExt> markers, int startMarker, int endMarker, ref List<float> leftIndents, ref List<float> rightIndents, ref List<float> leftSurrounding, ref List<float> rightSurrounding, float minRequiredIndent) { }

	public bool OCCQQDDDQC(SideObject obj, bool flag) { }

	public bool ODQCOQQDCD(SideObject obj, int marker, bool flag) { }

	public bool ERSetSideObjectOffset(SideObject obj, int marker, OffsetPosition position, float value) { }

	public bool ODQCOQQDCD(SideObject obj, int[] markers, bool flag) { }

	public List<Vector3> OQOQDCODCD(bool flag) { }

	public void OQOQDQCDCQ() { }

	public List<float> ODQQOQQDOO(Vector3[] tr) { }

	public Vector3 OOOOQCODCQ(float offset) { }

	public static Vector3 OODODQQQCD(Vector3 P0, Vector3 P1, Vector3 P2, Vector3 P3, float t, float tension) { }

	public Vector3 OCCDDOCCDQ(int startend, ERCrossingPrefabs prefab) { }

	public void OQDQOOQODD(bool lineMask, bool biomeMask) { }

	public void SetMarkerShape(List<Vector2> conVecs, Vector3 scale, ERCrossingPrefabs prefab, int connectionIndex) { }

	public void ODQOCQCCDC(ERIndentAlignment value, int marker, ERRoadSide type) { }

	public ERIndentAlignment ERGetIndentAlignment(int marker, ERRoadSide type) { }

	public void FlipRoadUVs(bool update) { }

	public ERRoadType GetRoadType(ERRoadType[] roadTypes) { }

	public void .ctor() { }

}

