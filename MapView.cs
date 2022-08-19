public class MapView : FacepunchBehaviour // TypeDefIndex: 10953
{	// Fields
	public RawImage mapImage; // 0x18
	public Image cameraPositon; // 0x20
	public ScrollRectEx scrollRect; // 0x28
	public GameObject monumentMarkerContainer; // 0x30
	public Transform clusterMarkerContainer; // 0x38
	public GameObjectRef monumentMarkerPrefab; // 0x40
	public GameObject missionMarkerContainer; // 0x48
	public GameObjectRef missionMarkerPrefab; // 0x50
	public TeamMemberMapMarker[] teamPositions; // 0x58
	public PointOfInterestMapMarker PointOfInterestMarker; // 0x60
	public PointOfInterestMapMarker LeaderPointOfInterestMarker; // 0x68
	public GameObject PlayerDeathMarker; // 0x70
	public List<SleepingBagMapMarker> SleepingBagMarkers; // 0x78
	public List<SleepingBagClusterMapMarker> SleepingBagClusters; // 0x80
	[FormerlySerializedAsAttribute] // RVA: 0x8CFC0 Offset: 0x8C3C0 VA: 0x18008CFC0
	public RawImage UndergroundLayer; // 0x88
	public bool ShowGrid; // 0x90
	public bool ShowPointOfInterestMarkers; // 0x91
	public bool ShowDeathMarker; // 0x92
	public bool ShowSleepingBags; // 0x93
	public bool ShowLocalPlayer; // 0x94
	public bool ShowTeamMembers; // 0x95
	public bool ShowTrainLayer; // 0x96
	public bool ShowMissions; // 0x97
	[FormerlySerializedAsAttribute] // RVA: 0x8D100 Offset: 0x8C500 VA: 0x18008D100
	public bool ShowUndergroundLayers; // 0x98
	public bool MLRSMarkerMode; // 0x99
	public RustImageButton LockButton; // 0xA0
	public RustImageButton OverworldButton; // 0xA8
	public RustImageButton TrainButton; // 0xB0
	public RustImageButton[] UnderwaterButtons; // 0xB8
	public static MapView ActiveView; // 0x0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <followingPlayer>k__BackingField; // 0xC0
	private Dictionary<MapMarker.ClusterType, List<MapMarker>> clusterDict; // 0xC8
	private List<GameObject> markersToRetire; // 0xD0
	private Dictionary<MapMarker, GameObject> markerLookup; // 0xD8
	private List<MonumentMarker> monumentMarkers; // 0xE0
	private List<MissionMapMarker> missionMarkers; // 0xE8
	private bool isShowingUndergroundLayers; // 0xF0
	private Nullable<MapLayer> undergroundLayerOverride; // 0xF4
	private MapLayer visibleLayer; // 0xFC
	internal static MapEntity lastActiveMap; // 0x8

	// Properties
	public bool followingPlayer { get; set; }
	private bool IsOpen { get; }
	public static float MarkerScale { get; }
	private static BasePlayer LocalPlayerEntity { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588350 Offset: 0x587750 VA: 0x180588350
	public bool get_followingPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x588360 Offset: 0x587760 VA: 0x180588360
	public void set_followingPlayer(bool value) { }

	// RVA: 0x5881D0 Offset: 0x5875D0 VA: 0x1805881D0
	private bool get_IsOpen() { }

	// RVA: 0x588300 Offset: 0x587700 VA: 0x180588300
	public static float get_MarkerScale() { }

	// RVA: 0x588260 Offset: 0x587660 VA: 0x180588260
	private static BasePlayer get_LocalPlayerEntity() { }

	// RVA: 0x582150 Offset: 0x581550 VA: 0x180582150
	private void Awake() { }

	// RVA: 0x585460 Offset: 0x584860 VA: 0x180585460
	public void SetActiveView() { }

	// RVA: 0x583550 Offset: 0x582950 VA: 0x180583550
	public void ClearActiveView() { }

	// RVA: 0x584640 Offset: 0x583A40 VA: 0x180584640
	public void MarkersDirty() { }

	// RVA: 0x586170 Offset: 0x585570 VA: 0x180586170
	private void SetupMonuments() { }

	// RVA: 0x585560 Offset: 0x584960 VA: 0x180585560
	private void SetupMarkers() { }

	// RVA: 0x5846F0 Offset: 0x583AF0 VA: 0x1805846F0
	public void PopulateMarker(MapMarker marker) { }

	// RVA: 0x584780 Offset: 0x583B80 VA: 0x180584780
	private void PopulateMarker(GameObject uiMarker, MapMarker marker) { }

	// RVA: 0x587520 Offset: 0x586920 VA: 0x180587520
	public void UpdatePointsOfInterest() { }

	// RVA: 0x5849B0 Offset: 0x583DB0 VA: 0x1805849B0
	public void PopulateSleepingBags() { }

	// RVA: 0x584290 Offset: 0x583690 VA: 0x180584290
	private SleepingBagMapMarker GetSleepingBagMarker() { }

	// RVA: 0x5841B0 Offset: 0x5835B0 VA: 0x1805841B0
	private SleepingBagClusterMapMarker GetSleepingBagClusterMarker() { }

	// RVA: 0x582180 Offset: 0x581580 VA: 0x180582180
	private void BuildMapMarkerClusters(List<MapMarker> markers, List<MapView.MapMarkerCluster> resultClusters, List<MapMarker> resultMarkers) { }

	// RVA: 0x582BB0 Offset: 0x581FB0 VA: 0x180582BB0
	private void BuildSpawnOptionClusters(List<RespawnInformation.SpawnOptions> spawnOptions, ref List<MapView.SleepingBagCluster> resultClusters, ref List<RespawnInformation.SpawnOptions> resultSleepingBags) { }

	// RVA: 0x5866B0 Offset: 0x585AB0 VA: 0x1805866B0
	private bool ShouldShowSleepingBags() { }

	// RVA: 0x586CD0 Offset: 0x5860D0 VA: 0x180586CD0
	private void UpdateMissionMarkers() { }

	// RVA: 0x586AF0 Offset: 0x585EF0 VA: 0x180586AF0
	public void UpdateMarkers() { }

	// RVA: 0x587B20 Offset: 0x586F20 VA: 0x180587B20
	private void Update() { }

	// RVA: 0x584130 Offset: 0x583530 VA: 0x180584130
	private MapLayer GetSelectedMapLayer() { }

	// RVA: 0x583E50 Offset: 0x583250 VA: 0x180583E50
	private static Nullable<MapLayer> GetCurrentUndergroundLayer() { }

	// RVA: 0x587EF0 Offset: 0x5872F0 VA: 0x180587EF0
	public Vector2 WorldPosToImagePos(Vector3 worldPos) { }

	// RVA: 0x584370 Offset: 0x583770 VA: 0x180584370
	public Vector3 ImagePosToWorldPos(Vector2 imagePos) { }

	// RVA: 0x583500 Offset: 0x582900 VA: 0x180583500
	public void CenterOn(Vector3 worldPos) { }

	// RVA: 0x587160 Offset: 0x586560 VA: 0x180587160
	public void UpdatePlayerPosition(BasePlayer player) { }

	// RVA: 0x583C80 Offset: 0x583080 VA: 0x180583C80
	public void DoPlayerUpdate() { }

	// RVA: 0x5835D0 Offset: 0x5829D0 VA: 0x1805835D0
	public void ClientTeamUpdated(bool positionsOnly = False) { }

	// RVA: 0x5845A0 Offset: 0x5839A0 VA: 0x1805845A0
	public void LockCurrentLayer() { }

	// RVA: 0x5867E0 Offset: 0x585BE0 VA: 0x1805867E0
	public void UnlockCurrentLayer() { }

	// RVA: 0x585500 Offset: 0x584900 VA: 0x180585500
	public void SetCurrentLayer(int layer) { }

	// RVA: 0x5867F0 Offset: 0x585BF0 VA: 0x1805867F0
	public void UpdateLayerButtons(Nullable<MapLayer> currentLayer) { }

	// RVA: 0x588030 Offset: 0x587430 VA: 0x180588030
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

private struct MapView.SleepingBagCluster // TypeDefIndex: 10954
{	// Fields
	public List<RespawnInformation.SpawnOptions> clusterMarkers; // 0x0
	public Vector3 centre; // 0x8

}

private struct MapView.MapMarkerCluster // TypeDefIndex: 10955
{	// Fields
	public List<MapMarker> markers; // 0x0
	public Vector3 centre; // 0x8

}

