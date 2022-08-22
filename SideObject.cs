public class SideObject : ScriptableObject // TypeDefIndex: 7189
{	public string version; // 0x18
	public string name; // 0x20
	public double id; // 0x28
	public double timestamp; // 0x30
	public int objectType; // 0x38
	public string gameobjectGUID; // 0x40
	public string textureGUID; // 0x48
	public float m_distance; // 0x50
	public float uvx; // 0x54
	public float uvy; // 0x58
	public int position; // 0x5C
	public float splinePosition; // 0x60
	public int selectedRotation; // 0x64
	public float randomYAxisMinRotation; // 0x68
	public float randomYAxisMaxRotation; // 0x6C
	public List<Vector2> nodeList; // 0x70
	public List<float> uvs; // 0x78
	public List<float> uvDistances; // 0x80
	public bool clampUVs; // 0x88
	public bool clampUVY; // 0x89
	public float clampUVYValue; // 0x8C
	public float totalDistance; // 0x90
	public bool reverseUVs; // 0x94
	public bool terrainUVs; // 0x95
	public List<bool> snapList; // 0x98
	public List<float> snapWeightList; // 0xA0
	public List<Color> colorList; // 0xA8
	public string gameobjectStartGUID; // 0xB0
	public string gameobjectEndGUID; // 0xB8
	public int align; // 0xC0
	public int alignPoint; // 0xC4
	public bool weld; // 0xC8
	public bool combine; // 0xC9
	public bool combineInstantiated; // 0xCA
	public bool markerActive; // 0xCB
	public int uvType; // 0xCC
	public float uv; // 0xD0
	public bool randomObjects; // 0xD4
	public float forwardStartOffset; // 0xD8
	public float sidewaysOffset; // 0xDC
	public float density; // 0xE0
	public string goPath; // 0xE8
	public string startPath; // 0xF0
	public string endPath; // 0xF8
	public string texturePath; // 0x100
	public int terrainTree; // 0x108
	public float minScale; // 0x10C
	public float maxScale; // 0x110
	public bool childOrderActive; // 0x114
	public int childOrder; // 0x118
	public bool meshBoundsAlignment; // 0x11C
	public float xPosition; // 0x120
	public float xPosition2; // 0x124
	public int relativeTo; // 0x128
	public float yPosition; // 0x12C
	public float yRotation; // 0x130
	public float oldSidwaysDistance; // 0x134
	public int sidewaysDistanceUpdate; // 0x138
	public float uvYRound; // 0x13C
	public bool adjustUV; // 0x140
	public bool collider; // 0x141
	public bool boxcollider; // 0x142
	public bool tangents; // 0x143
	public GameObject sourceObject; // 0x148
	public bool flipMesh; // 0x150
	public GameObject startObject; // 0x158
	public GameObject endObject; // 0x160
	public GameObject connectionObject; // 0x168
	public Material material; // 0x170
	public List<ERMesh> meshObjects; // 0x178
	public Vector2 boxSize; // 0x180
	public Vector2 boxOffset; // 0x188
	public bool includeStartSegment; // 0x190
	public float startSegmentOffset; // 0x194
	public bool includeStartEdgeTris; // 0x198
	public bool includeEndSegment; // 0x199
	public float endSegmentOffset; // 0x19C
	public bool includeEndEdgeTris; // 0x1A0
	public bool adjustToRoadWidth; // 0x1A1
	public float xOffset; // 0x1A4
	public float startOffset; // 0x1A8
	public float endOffset; // 0x1AC
	public float defaultStartOffset; // 0x1B0
	public float defaultEndOffset; // 0x1B4
	public float totalZDistance; // 0x1B8
	public float middleZDistance; // 0x1BC
	public float startZDistance; // 0x1C0
	public float endZDistance; // 0x1C4
	public float minStartZ; // 0x1C8
	public float maxStartZ; // 0x1CC
	public float minMiddleZ; // 0x1D0
	public float maxMiddleZ; // 0x1D4
	public float minEndZ; // 0x1D8
	public float maxEndZ; // 0x1DC
	public bool smoothStart; // 0x1E0
	public bool smoothMiddle; // 0x1E1
	public bool smoothEnd; // 0x1E2
	public GameObject targetObject; // 0x1E8
	public bool bridgeObject; // 0x1F0
	public bool tunnelObject; // 0x1F1
	public bool snapToTerrain; // 0x1F2
	public int layer; // 0x1F4
	public bool deformationObject; // 0x1F8
	public bool isStatic; // 0x1F9
	public bool castShadows; // 0x1FA
	public bool scaleToRoad; // 0x1FB
	public bool splitInBatches; // 0x1FC
	public List<GameObject> instantiatedObjects; // 0x200
	public int maxVertices; // 0x208
	public bool doTestmesh; // 0x20C
	public Vector3 testMeshPos; // 0x210
	public Vector3 randomRotation; // 0x21C
	public float randomMinRotation; // 0x228
	public float randomMaxRotation; // 0x22C
	public float minRandomRotationDistance; // 0x230
	public float maxRandomRotationDistance; // 0x234
	public float randomXPosition; // 0x238
	public float randomMinXPosition; // 0x23C
	public float randomMaxXPosition; // 0x240
	public float minRandomXPositionDistance; // 0x244
	public float maxRandomXPositionDistance; // 0x248
	public Vector3 boxColliderScale; // 0x24C
	public float randomYPosition; // 0x258
	public float randomMinYPosition; // 0x25C
	public float randomMaxYPosition; // 0x260
	public float minRandomYPositionDistance; // 0x264
	public float maxRandomYPositionDistance; // 0x268
	public bool indentController; // 0x26C
	public bool excludeTerrainSplats; // 0x26D
	public float x1; // 0x270
	public float x2; // 0x274
	public float xf1; // 0x278
	public float xf2; // 0x27C
	public float y1; // 0x280
	public float bridgeHeight; // 0x284
	public int markerSplineController; // 0x288
	public float bridgeLength; // 0x28C
	public float deformationOffset; // 0x290
	public float markerIndent; // 0x294
	public float markerSurrounding; // 0x298
	public Vector3 scale; // 0x29C
	public float indentExt; // 0x2A8
	public int category; // 0x2AC
	public Texture2D densityMap; // 0x2B0
	public float densitySize; // 0x2B8
	public float densitySize2; // 0x2BC
	public float densityStrength; // 0x2C0
	public float densityStrength2; // 0x2C4
	public float terrainNormal; // 0x2C8
	public float terrainNormal2; // 0x2CC
	public List<ERChildsSO> childObjects; // 0x2D0
	public bool autoGenerate; // 0x2D8
	public float heightThreshold; // 0x2DC
	public float autogenerateStartOffset; // 0x2E0
	public float autogenerateEndOffset; // 0x2E4
	public bool snapIndents; // 0x2E8
	public float snapIndentWidth; // 0x2EC
	public bool cutHoles; // 0x2F0
	public float innerStartOffset; // 0x2F4
	public float innerEndOffset; // 0x2F8
	public bool ignoredForRetainingWalls; // 0x2FC
	public float heightMaxThreshold; // 0x300
	public float heightMaxStartThreshold; // 0x304
	public float heightMaxEndThreshold; // 0x308
	public float xThresholdDistance; // 0x30C
	public float angleThreshold; // 0x310
	public int connectionRatio; // 0x314
	public bool retainingWall; // 0x318
	public int surroundingControl; // 0x31C
	public int indentControl; // 0x320
	public List<Vector2> nodeListMirrored; // 0x328
	public List<float> uvsMirrored; // 0x330
	public List<float> snapWeightListMirrored; // 0x338
	public List<Color> colorListMirrored; // 0x340
	public bool hasVertexColors; // 0x348
	public float deformationOffsetForward; // 0x34C
	public float deformationOffsetSideways; // 0x350
	public int connectionObjectRotation; // 0x354
	public bool subMesh; // 0x358
	public bool acceptBarriers; // 0x359
	public bool activeOnBridges; // 0x35A
	public bool dualSided; // 0x35B
	public int mirrorType; // 0x35C
	public bool snapVertexColors; // 0x360
	public float minSnapRange; // 0x364
	public float maxSnapRange; // 0x368
	public bool clampUV4; // 0x36C
	public float geoStartOffset; // 0x370
	public float geoEndOffset; // 0x374
	public float startOverlapOffset; // 0x378
	public float endOverlapOffset; // 0x37C
	public int lodLevels; // 0x380
	public List<bool> hardEdge; // 0x388
	public float hardEdgePadding; // 0x390
	public bool startEndCaps; // 0x394
	public List<Vector2> endCapUVs; // 0x398
	public List<Vector2> startCapUVs; // 0x3A0
	public List<int> startCapTris; // 0x3A8
	public List<int> startCapTrisMirrored; // 0x3B0
	public Vector2 startCapUVOffset; // 0x3B8
	public Vector2 endCapUVOffset; // 0x3C0
	public float startCapUVScale; // 0x3C8
	public float endCapUVScale; // 0x3CC
	public float startCapUVRotation; // 0x3D0
	public float endCapUVRotation; // 0x3D4
	public bool namedChilds; // 0x3D8
	public bool startSection; // 0x3D9
	public bool endSection; // 0x3DA
	public bool stepDown; // 0x3DB
	public bool stepUp; // 0x3DC
	public float stepDistance; // 0x3E0
	public float startDirZOffset; // 0x3E4
	public float endDirZOffset; // 0x3E8
	public bool buildOtherSideObject1; // 0x3EC
	public double defaultOtherSoId1; // 0x3F0
	public bool buildOtherSideObject2; // 0x3F8
	public double defaultOtherSoId2; // 0x400
	public List<double> buildOtherSideObjects; // 0x408
	public bool averageDistance; // 0x410
	public bool randomUVx; // 0x411
	public bool isUsedAsChild; // 0x412


	public void SetSideObject(int count, int scategory) { }

	public void UpdateTimeStamp() { }

	public void OOCCDCDOQC() { }

	public void OQOQOQOODC() { }

	public void SetMaxVertices() { }

	public static bool CheckSOChildActive(List<ERSOSection> sections, SideObject so) { }

	public void OOOCDOQOOC(bool updateTimeStamp) { }

	public void OQDODCOODC() { }

	public void OQDDDDOOQD(Vector3 m_testMeshPos, bool updateTimeStamp) { }

	private void OQOODQQQQC(List<Vector3> vecs, float startDistance, List<Vector3> vecs1, float endDistance, ref List<int> startArray, ref List<int> endArray, int section) { }

	private float OQQDDOCDDQ(List<GameObject> goObjects, bool rotate180) { }

	private bool HasMissingData(ERMesh meshData, ERMesh meshData2, int ignore) { }

	public void OODOOOQQCO(SideObject so) { }

	public void OCDOCDQQQO(SideObjectLog so) { }

	public void Clear() { }

	public void .ctor() { }

}

