public class ERModularBase : MonoBehaviour // TypeDefIndex: 7215
{
	public int updateInt;
	public bool newSplatMapRestoreCode;
	public int toolbarInt;
	public int oldToolbarInt;
	public int roadToolbarInt;
	public int markerToolbarInt;
	public Texture[] menuTexs;
	public Texture[] subMenuTexs;
	public GameObject cprefab;
	public Texture nodeHandleTexture;
	public Texture lockedTexture;
	public Texture unLockedTexture;
	public Texture favOffTexture;
	public Texture favOffFreeTexture;
	public Texture favOnTexture;
	public Texture selRoadTexture;
	public Texture headerTexture;
	public Texture sceneGUITex;
	public Texture soIcon;
	public Transform roadObjectsParent;
	public Transform connectionObjectsParent;
	public GameObject OCOQDODDQQ;
	public List<QDQDOOQQDQODD> roadTypes;
	public int selectedRoadType;
	public int selectedNewRoadType;
	public List<QDQDOOQQDQODD> inspRoadTypes;
	public List<int> inspRoadTypeInts;
	public List<ERDecal> decalPresets;
	public float roadWidth;
	public Material roadMaterial;
	public Material crossingMaterial;
	public Material roundAboutMaterial;
	public Material roundAboutConnectionMaterial;
	public Material roundAboutRoadMaterial;
	public Material sidewalkMaterial;
	public Material targetMaterial;
	public Terrain sourceTerrain;
	public string[] roadMaterials;
	public string[] connectionMaterials;
	public int selectedMaterial;
	public int selectedConnectionMaterial;
	public List<ERMaterial> materials;
	public int selectedRoadRoadType;
	public bool roadOptions;
	public bool sidewalkOptions;
	public bool markerOptions;
	public bool showRoadSideObjects;
	public bool markerSOOptions;
	public bool roadTerrainOptions;
	public bool camFlyOver;
	public int selectedRoadMaterial;
	public int roadTextureInfoIndex;
	public Texture2D selectedRoadTexture;
	public float selectedRoadWidth;
	public float selectedRoadLeftOffset;
	public float selectedRoadRightOffset;
	public float selectedRoadLeftInnerOffset;
	public float selectedRoadRightInnerOffset;
	public int selectedCrossingMaterial;
	public int crossingTextureInfoIndex;
	public int handleSelection;
	public int positionHandleSelection;
	public bool markerDirXZ;
	public GameObject defaultCrossing;
	public GameObject defaultTCrossing;
	public GameObject defaultCulDeSac;
	public GameObject defaultRoundabout;
	public Texture2D tex;
	public Texture2D infoTexture;
	public bool showAllPrefabs;
	public bool standardPrefabsFlag;
	public bool sceneSettingsFoldOut;
	public bool sceneRoadsFoldOut;
	public bool scenePrefabsFoldOut;
	public bool sidewalksFoldOut;
	public bool terrainManagementFoldOut;
	public bool importRoadDataFoldOut;
	public bool lodGroupsFoldOut;
	public bool defaultMaterialsFoldOut;
	public bool aiTrafficFoldout;
	public bool kmlFlag;
	public bool osmFlag;
	public bool useOSMHeights;
	public float heightRatio;
	public bool dynamicPrefabsFoldOut;
	public bool customPrefabsFoldOut;
	public List<ERConnectionGUIStatus> dynamicFavList;
	public List<ERConnectionGUIStatus> customFavList;
	public float prefabsDisplayType;
	public bool ignoreTerrainAlerts;
	public double osmTerrainTopLon;
	public double osmTerrainBottomLon;
	public double osmTerrainLeftLat;
	public double osmTerrainRightLat;
	public float terrainMinIndent;
	public float minIndent;
	public float minSurrounding;
	public float maxIndentSurrounding;
	public float terrainY;
	public float terrainDetailSplatX;
	public float terrainDetailSplatY;
	public Vector3 detailOffsetVec;
	public float raise;
	public Vector3 baseVector;
	public bool mirrorCrossings;
	public string[] terrainNames;
	public Terrain[] terrainObjects;
	public string[] terrainSplatTextures;
	public Terrain activeTerrain;
	public float activeTerrainY;
	public int selectedTerrain;
	public bool selectedRoadsOnly;
	public bool terrainDone;
	public bool enableBackWithoutRestore;
	public float detailDistance;
	public float treeDistance;
	public bool doHeightmap;
	public bool doTrees;
	public bool soTrees;
	public bool doDetail;
	public Rect terrainRect;
	public List<GameObject> tunnelObjects;
	public List<GameObject> surfaceObjects;
	public float preserveTerrainFloat;
	public float terrainSmoothIndentDistance;
	public float terrainSmoothSurroundingDistance;
	public int indentSmoothStep;
	public int surroundingSmoothStep;
	public bool doTangents;
	public bool doLightmapUVs;
	public bool doLODGroups;
	public bool doSplatmaps;
	public int sLayer;
	public List<Vector3> terrainHits;
	public List<Vector3> osmCrossingPoints;
	public List<CrossingCornerClass> cornerPresets;
	public List<SidewalkPresetClass> sidewalkPresets;
	public List<ERSideWalk> sidewalks;
	public int selectedSidewalk;
	public int selectedRoadTypeSidewalk;
	public int osmMotorway;
	public int osmMotorwayLink;
	public int osmTrunk;
	public int osmPrimary;
	public int osmSecondary;
	public int osmTertiary;
	public int osmUnclassified;
	public int osmResidential;
	public int osmService;
	public int osmTrack;
	public int osmPath;
	public int osmWalkway;
	public int osmRaceway;
	public int osmHighwayStringInt;
	public bool osmMotorwayFlag;
	public bool osmMotorwayLinkFlag;
	public bool osmTrunkFlag;
	public bool osmPrimaryFlag;
	public bool osmSecondaryFlag;
	public bool osmTertiaryFlag;
	public bool osmUnclassifiedFlag;
	public bool osmResidentialFlag;
	public bool osmServiceFlag;
	public bool osmTrackFlag;
	public bool osmPathFlag;
	public bool osmWalkwayFlag;
	public bool osmRacewayFlag;
	public string osmHighwayString;
	public int kmlRoadType;
	public bool lodGroups;
	public int LODLevels;
	public List<float> LODLevelValues;
	public List<float> LODLevelResolution;
	public bool embedRoadShape;
	public bool hideSurfaces;
	public bool showSurfaces;
	public bool useLightProbes;
	public bool hideLockedObjects;
	public bool ODQCODODDD;
	public bool isInBuildMode;
	public bool progressFlag;
	public int progressTerrain;
	public float progressStatus;
	public float progressMax;
	[SerializeField]
	public List<SideObject> QOQDQOOQDDQOOQ;
	public string[] sideObjectNames;
	public int selSideObject;
	public int selSubSideObject;
	public string soID;
	public string sideObjectName;
	[SerializeField]
	public int sideObjectType;
	public GameObject sideObjectSource;
	public GameObject soEndObject;
	public int sideObjectTerrainVegetationInt;
	public int prefabChildHandling;
	public float sideObjectDistance;
	public int soYAxisRotation;
	public float soSidewaysDistance;
	public int soSidewaysDistanceHandling;
	public float soDensity;
	public float soOffset;
	public int soTerrainAligment;
	public bool soCombine;
	public bool soWeld;
	public int soControllerType;
	public Material soMaterial;
	public float soXPosition;
	public float soYPosition;
	public bool soMarkerActive;
	public bool enableSOHandles;
	public bool enableShapeNodeHandles;
	public bool enableSOShapeNodeHandles;
	public bool displayCriticalPoints;
	public bool highlightRoad;
	public bool highlightIndents;
	public bool highlightSurroundings;
	public bool highlightSideObject;
	public Color highlightRoadColor;
	public Color highlightIndentColor;
	public Color highlightSurroundingColor;
	public bool onlyShowSelectedRoad;
	public List<GameObject> soDeformationObjects;
	public List<GameObject> soSplatmapObjects;
	public bool buildSOinEditMode;
	public bool tangentsInEditMode;
	public bool calculateSmoothNormals;
	public bool importSideObjectsAlert;
	public bool importRoadPresetsAlert;
	public bool importCrossingPresetsAlert;
	public bool importSidewalkPresetsAlert;
	public bool updateSideObjectsAlert;
	public bool updateRoadPresetsAlert;
	public bool updateCrossingPresetsAlert;
	public bool updateSidewalkPresetsAlert;
	public float waypointDistance;
	public List<ERModularRoad> RoadObjectsSoUpdates;
	public string assetsFolderID;
	public GameObject meshSurface;
	public Collider meshTerrainCollider;
	public float markerScale;
	public float markerDistance;
	public float minMarkerDistance;
	public float maxMarkerDistance;
	public bool debugFlag;
	public List<Vector3> leftTHandles;
	public List<Vector3> rightTHandles;
	public float roadNetworkY;
	public bool ignoreMinIndents;
	public Vector3 zoomStart;
	public Vector3 zoomEnd;
	public Vector3 lookAtStart;
	public Vector3 lookAtEnd;
	public Quaternion zoomRot;
	public float zoomStartTime;
	public bool hideSurfaceHandles;
	public bool dirtyBool;
	public bool dirtyOnSceneBool;
	public bool forceRoadNetworkSelect;
	public bool ODQDQDQDCO;
	public ERCrossingPrefabs OCOQDODDQQScript;
	public ERCrossings OOOQDOQCCOCrossingsScript;
	public ERCrossingPrefabs OOOQDOQCCOScript;
	public int OCOQDODDQQElement;
	public int OQCOQCOQQQ;
	public ERModularRoad OCCQOOOQQO;
	public ERModularRoad OODDQOOCOD;
	public int OCODDDQOQC;
	public int selectedRoadSOMarker;
	public int selectedMarkerNode;
	public List<int> selectedMarkerNodes;
	public int selectedMarkerSONode;
	public List<int> selectedMarkerSONodes;
	public List<SelectedObject> selectedObjects;
	public int selectedExitRoad;
	public bool newRoadFlag;
	public bool roadTypeUpdateFlag;
	public List<ERModularRoad> roadScripts;
	public List<ERCrossingPrefabs> prefabScripts;
	public bool globalGridActive;
	public bool gridGUIActive;
	public Color globalGridColor;
	public float globalGridSize;
	public float globalGridRadius;
	public float globalGridRotation;
	public Vector2 gridOffset;
	public Vector3 ggTL;
	public Vector3 ggBL;
	public Vector3 ggBR;
	public bool localGridActive;
	public List<ERLocalGrid> localGrids;
	public int selectedLocalGrid;
	public MethodInfo crMethod;
	public MethodInfo upMethod;
	public MethodInfo hmMethod;
	public MethodInfo rmMethod;
	public MethodInfo crBiomeMethod;
	public MethodInfo upBiomeMethod;
	public MethodInfo rmBiomeMethod;
	public MethodInfo thMethodGet;
	public MethodInfo thMethodSet;
	public ERSideWalk sw;
	public bool roadUpdated;
	public bool clampUVs;
	public int soCategoryInt;
	public int soRoadCategoryInt;
	public float minRoadWidth;
	public float maxRoadWidth;
	public float maxCurbHeight;
	public float minCornerRadius;
	public float maxCornerRadius;
	public GameObject SoTestObject;
	public bool lockRoadNetwork;
	public bool showNotifications;
	public bool multipleTerrainsWarning;
	public Texture2D[] OCDCDDQDQC;
	public Texture2D[] OCDCOCCCCC;
	public int textureCounter;
	public static bool AssembliesSet;
	public bool vegetationStudio;
	public bool vegetationStudioPro;
	public bool vegetationStudioActive;
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
	public bool aiTraffic;
	public bool aiMatchingLanesOnly;
	public bool aiconnectNonMatchinglaneCounts;
	public bool aiIgnoreConnections;
	public bool displayLaneData;
	public int rightHandDriving;
	public Color leftLaneHandleColour;
	public Color rightLaneHandleColour;
	public Color laneHandleSelectedColour;
	public float roadUvThreshold;
	public int updateQueue;
	public static bool checkPresets;
	public bool logChange;
	public bool debugMode;
	public bool RoadNetworkInitFlag;
	public static ERModularBase.RoadUpdate onRoadUpdate;
	public static ERModularBase.OnBuildMode onBuildModeEnter;
	public List<GameObject> excludeFromSelection;
	public GameObject addExcludeFromSelection;
	public Color shapeUVColor;
	public Color startCapColor;
	public Color endCapColor;
	public Material soSectionMaterial;
	public bool v32b4Flag;


	public void OnBuildModeEnter() { }

	public void OnRoadUpdate(ERRoad road) { }

	public void RoadNetworkInit() { }

	public void UpdateQueue() { }

	public void SetRoadTypeList() { }

	public void UpdateRoadTypeStatus() { }

	public void OCOCQOODCO() { }

	public void OCQODDDCQQ() { }

	public void ODODOQOODO() { }

	public void OOCQCCCQCD() { }

	public void OQDQQODDCD(GameObject go, Vector3 pos) { }

	public void ODCDQQCQOC() { }

	public ERCrossingPrefabs OCDQQCQCQQ(GameObject prefab, ERModularRoad OCCQOOOQQO, int OCODDDQOQC, int connectionSegment) { }

	public ERCrossingPrefabs AttachConnector(ERModularRoad OCCQOOOQQO, int OCODDDQOQC) { }

	public void OCCDCDQOOD(ERModularRoad OCCQOOOQQO, int selectedMarker) { }

	public int OOOCOQQDQO(ERModularRoad OCCQOOOQQO, ERCrossingPrefabs prefabScript, int OCODDDQOQC, int startConnection, bool swapFlag) { }

	public int OOQQQQCCOC(string roadShapeString, List<string> strings, List<QDOODOQQDQODD> crossingElements) { }

	public GameObject OOQDQOOQQQ(GameObject prefab, Vector3 hitPos, ref GameObject newPrefab, ref ERCrossingPrefabs prefabScript, ref ERCrossings crossingsScript) { }

	public void OQOCDOOQCQ(ERCrossingPrefabs prefabScript) { }

	public void OQCDDCDDQC(GameObject newPrefab, GameObject prefab) { }

	public void ODDQCOQCQC() { }

	public List<ERTerrain> OODQQODOOC(ref bool multTerrainResFlag) { }

	public void ODDCCODOOC() { }

	public void OQQQDCQOOC(bool restoreTerrain) { }

	public void OQQOOCQQCD(Vector3 pos) { }

	public void OCDDQOCDCO(ref Vector3 pos) { }

	public Vector3 OQOODODDQO(Vector3 pos) { }

	public Vector2 GetTerrainUV(Vector3 pos) { }

	public Terrain OQOQDDOQOD(ref Vector3 pos, bool setSelected) { }

	public void OQCQQQDQQD() { }

	public void UpdateLODLevels(int levels) { }

	public void UpdateSideObjectsInScene() { }

	public void OOCDOOCQQC() { }

	public void OQQDDOQQOO() { }

	public ERRoadType[] GetRoadTypes() { }

	public ERRoadType GetRoadTypeByName(string name) { }

	public string GetNewRoadName(double id) { }

	public string GetRoadNameByID(double id) { }

	public SideObject OQCDCQCDCQ(string name) { }

	public void InitLoadImage(string url) { }

	private IEnumerator LoadImage(string url) { }

	public IEnumerator BuildTerrainRoutine(ERRoadNetwork roadNetwork) { }

	public float OCCQDCCCOD(Vector3 fwd, Vector3 targetDir, Vector3 up) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public sealed class ERModularBase.RoadUpdate : MulticastDelegate // TypeDefIndex: 7216
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(ERRoad road) { }

	public virtual IAsyncResult BeginInvoke(ERRoad road, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class ERModularBase.OnBuildMode : MulticastDelegate // TypeDefIndex: 7217
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke() { }

	public virtual IAsyncResult BeginInvoke(AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

private sealed class ERModularBase.ᙃ : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 7218
{
	private int ᙅ;
	private object 4AAAA;
	public string url;
	public ERModularBase <>4__this;
	private WWW 5AAA1;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

private sealed class ERModularBase.ᙄ : IEnumerator<object>, IDisposable, IEnumerator // TypeDefIndex: 7219
{
	private int ᙅ;
	private object 4AAAA;
	public ERRoadNetwork roadNetwork;
	public ERModularBase <>4__this;

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute]
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute]
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute]
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute]
	private object System.Collections.IEnumerator.get_Current() { }

}

