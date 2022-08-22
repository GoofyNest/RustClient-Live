public class QDQDOOQQDQODD // TypeDefIndex: 7194
{	public string roadTypeName; // 0x10
	public double id; // 0x18
	public double timestamp; // 0x20
	public float roadWidth; // 0x28
	public float faceDistance; // 0x2C
	public float angleTreshold; // 0x30
	public float uvTiling; // 0x34
	public int uv4Type; // 0x38
	public ERRoadWayType type; // 0x3C
	public float detailDistance; // 0x40
	public bool planarUVs; // 0x44
	public float outerIndent; // 0x48
	public bool roadShapeDataActive; // 0x4C
	public ERRoadShape roadShapeData; // 0x50
	public float minSpeed; // 0xB0
	public float maxSpeed; // 0xB4
	public float speedLimit; // 0xB8
	public List<Vector2> roadShape; // 0xC0
	public List<Vector2> roadShapeExt; // 0xC8
	public List<Vector2> roadShapeExt2; // 0xD0
	public List<bool> doConnectionTri; // 0xD8
	public List<bool> doConnectionTriExt; // 0xE0
	public List<float> roadShapeUVs; // 0xE8
	public List<float> roadShapeExtUVs; // 0xF0
	public List<float> roadShapeExtUVs2; // 0xF8
	public List<float> roadShapeUVs2; // 0x100
	public bool preserveUVs; // 0x108
	public List<bool> hardEdge; // 0x110
	public string roadShapeVecsString; // 0x118
	public double defaultSidewalk; // 0x120
	public bool sidewalks; // 0x128
	public float sidewalkHeight; // 0x12C
	public float sidewalkWidth; // 0x130
	public Material roadMaterial; // 0x138
	public Material[] roadMaterials; // 0x140
	public PhysicMaterial roadPhysicsMaterial; // 0x148
	public PhysicMaterial[] roadPhysicsMaterials; // 0x150
	public Material connectionMaterial; // 0x158
	public bool isSideObject; // 0x160
	public bool isCustomRoad; // 0x161
	public int subSegments; // 0x164
	public List<ERSORoad> soData; // 0x168
	public List<ERSORoadExt> soDataExt; // 0x170
	public List<ERSORoadLog> soDataLog; // 0x178
	public int layer; // 0x180
	public bool isStatic; // 0x184
	public string tag; // 0x188
	public bool splatMapActive; // 0x190
	public int splatIndex; // 0x194
	public int expandLevel; // 0x198
	public int smoothLevel; // 0x19C
	public float splatOpacity; // 0x1A0
	public bool followTerrainContours; // 0x1A4
	public float terrainContoursOffset; // 0x1A8
	public bool terrainDeformation; // 0x1AC
	public float defaultIndent; // 0x1B0
	public float defaultSurrounding; // 0x1B4
	public bool castShadow; // 0x1B8
	public bool randomnessFlag; // 0x1B9
	public float randomYPosition; // 0x1BC
	public float randomMinYPosition; // 0x1C0
	public float randomMaxYPosition; // 0x1C4
	public float minRandomYPositionDistance; // 0x1C8
	public float maxRandomYPositionDistance; // 0x1CC
	public float randomMinRotation; // 0x1D0
	public float randomMaxRotation; // 0x1D4
	public float minRandomRotationDistance; // 0x1D8
	public float maxRandomRotationDistance; // 0x1DC
	public bool vegetationStudioMaskLineActive; // 0x1E0
	public float vegetationStudioGrassPerimeter; // 0x1E4
	public float vegetationStudioPlantPerimeter; // 0x1E8
	public float vegetationStudioTreePerimeter; // 0x1EC
	public float vegetationStudioObjectPerimeter; // 0x1F0
	public float vegetationStudioLargeObjectPerimeter; // 0x1F4
	public bool vegetationStudioBiomeMaskActive; // 0x1F8
	public float vegetationStudioBiomeMaskDistance; // 0x1FC
	public float vegetationStudioBiomeMaskBlendDistance; // 0x200
	public float vegetationStudioBiomeMaskNoiseScale; // 0x204
	public List<ERDecal> decalPresets; // 0x208
	public List<ERDecalClass> decalClassPresets; // 0x210
	public double defaultRamp; // 0x218
	public int extrusionType; // 0x220
	public float extrusionDistance; // 0x224
	public float fixedDistance; // 0x228
	public float connectionAngle; // 0x22C
	public float connectionRadius; // 0x230
	public int isRoadShape; // 0x234
	public int controlType; // 0x238


	public void RoadTypeUpgrade() { }

	public int GetTagIndex(string[] tags) { }

	public static int GetTagIndex(string[] tags, string tag) { }

	public void OQQOCCODOD() { }

	public void .ctor(int count) { }

	public void UpdateTimestamp() { }

	public static bool ODQDDOCDDC(ERModularBase scr) { }

	public static string[] RoadNames(List<QDQDOOQQDQODD> roadTypes) { }

	public static string[] Nodes(ERRoadShape data) { }

	public static string[] LaneNodes(ERRoadShape data) { }

	public static GUIContent[] LaneNodesContents(ERRoadShape data) { }

	public void ODQQQODOQD() { }

	public static int SetRoadType(List<QDQDOOQQDQODD> roadTypes, double roadType) { }

	public void UpdateUVs() { }

	public static QDQDOOQQDQODD GetRoadTypeElByID(List<QDQDOOQQDQODD> roadTypes, double id) { }

	public static int ODDQDCOODD(List<QDQDOOQQDQODD> roadTypes, double id, ref string[] ramps, ref QDQDOOQQDQODD[] rampTypes) { }

	public static int GetRoadTypeByID(List<QDQDOOQQDQODD> roadTypes, double id) { }

	public static bool OOQDCODDCO(List<QDQDOOQQDQODD> roadTypes, double id, ref QDQDOOQQDQODD motorwayLink) { }

	public static string[] ODODCOQODO(List<QDQDOOQQDQODD> roadTypes) { }

	public static bool GetTerrainDeformationByID(List<QDQDOOQQDQODD> roadTypes, double id, ref int element) { }

	public static void UpdateUVTiling(List<QDQDOOQQDQODD> roadTypes, double id, float tiling) { }

	public static void UpdateResolution(List<QDQDOOQQDQODD> roadTypes, double id, ref float resolution, ref float threshold) { }

	public void OCDOCDQQQO(QDQDOOQQDQODD sourcePreset, List<SideObject> sceneSideObjects, List<SideObjectLog> projectSideObjects, bool copyShapeData) { }

	public static void OOOCDCQQCO(QDQDOOQQDQODD sourcePreset, ERModularRoad road, bool update, int customShapeHandling, bool checkRoadWidth) { }

	public static void AssignSideObjects(ERModularBase scr, int roadTypeInt, ERModularRoad OCCQOOOQQO) { }

	public static void HasActiveSideObjects(List<ERSORoadExt> sos1, List<ERSORoadExt> sos2, ref bool flag1, ref bool flag2) { }

	public int OOOOCQCDDC(int index, ERLaneDirection direction) { }

	public static bool ODCDDDQCQQ(QDQDOOQQDQODD rt1, QDQDOOQQDQODD rt2) { }

}

