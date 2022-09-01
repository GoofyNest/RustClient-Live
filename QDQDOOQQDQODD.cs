public class QDQDOOQQDQODD // TypeDefIndex: 7195
{
	public string roadTypeName; 
	public double id; 
	public double timestamp; 
	public float roadWidth; 
	public float faceDistance; 
	public float angleTreshold; 
	public float uvTiling; 
	public int uv4Type; 
	public ERRoadWayType type; 
	public float detailDistance; 
	public bool planarUVs; 
	public float outerIndent; 
	public bool roadShapeDataActive; 
	public ERRoadShape roadShapeData; 
	public float minSpeed; 
	public float maxSpeed; 
	public float speedLimit; 
	public List<Vector2> roadShape; 
	public List<Vector2> roadShapeExt; 
	public List<Vector2> roadShapeExt2; 
	public List<bool> doConnectionTri; 
	public List<bool> doConnectionTriExt; 
	public List<float> roadShapeUVs; 
	public List<float> roadShapeExtUVs; 
	public List<float> roadShapeExtUVs2; 
	public List<float> roadShapeUVs2; 
	public bool preserveUVs; 
	public List<bool> hardEdge; 
	public string roadShapeVecsString; 
	public double defaultSidewalk; 
	public bool sidewalks; 
	public float sidewalkHeight; 
	public float sidewalkWidth; 
	public Material roadMaterial; 
	public Material[] roadMaterials; 
	public PhysicMaterial roadPhysicsMaterial; 
	public PhysicMaterial[] roadPhysicsMaterials; 
	public Material connectionMaterial; 
	public bool isSideObject; 
	public bool isCustomRoad; 
	public int subSegments; 
	public List<ERSORoad> soData; 
	public List<ERSORoadExt> soDataExt; 
	public List<ERSORoadLog> soDataLog; 
	public int layer; 
	public bool isStatic; 
	public string tag; 
	public bool splatMapActive; 
	public int splatIndex; 
	public int expandLevel; 
	public int smoothLevel; 
	public float splatOpacity; 
	public bool followTerrainContours; 
	public float terrainContoursOffset; 
	public bool terrainDeformation; 
	public float defaultIndent; 
	public float defaultSurrounding; 
	public bool castShadow; 
	public bool randomnessFlag; 
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
	public List<ERDecal> decalPresets; 
	public List<ERDecalClass> decalClassPresets; 
	public double defaultRamp; 
	public int extrusionType; 
	public float extrusionDistance; 
	public float fixedDistance; 
	public float connectionAngle; 
	public float connectionRadius; 
	public int isRoadShape; 
	public int controlType; 


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

