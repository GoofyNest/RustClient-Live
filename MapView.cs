public class MapView : FacepunchBehaviour // TypeDefIndex: 10953
{	public RawImage mapImage; // 0x18
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

	public bool followingPlayer { get; set; }
	private bool IsOpen { get; }
	public static float MarkerScale { get; }
	private static BasePlayer LocalPlayerEntity { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_followingPlayer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void set_followingPlayer(bool value) { }

	private bool get_IsOpen() { }

	public static float get_MarkerScale() { }

	private static BasePlayer get_LocalPlayerEntity() { }

	private void Awake() { }

	public void SetActiveView() { }

	public void ClearActiveView() { }

	public void MarkersDirty() { }

	private void SetupMonuments() { }

	private void SetupMarkers() { }

	public void PopulateMarker(MapMarker marker) { }

	private void PopulateMarker(GameObject uiMarker, MapMarker marker) { }

	public void UpdatePointsOfInterest() { }

	public void PopulateSleepingBags() { }

	private SleepingBagMapMarker GetSleepingBagMarker() { }

	private SleepingBagClusterMapMarker GetSleepingBagClusterMarker() { }

	private void BuildMapMarkerClusters(List<MapMarker> markers, List<MapView.MapMarkerCluster> resultClusters, List<MapMarker> resultMarkers) { }

	private void BuildSpawnOptionClusters(List<RespawnInformation.SpawnOptions> spawnOptions, ref List<MapView.SleepingBagCluster> resultClusters, ref List<RespawnInformation.SpawnOptions> resultSleepingBags) { }

	private bool ShouldShowSleepingBags() { }

	private void UpdateMissionMarkers() { }

	public void UpdateMarkers() { }

	private void Update() { }

	private MapLayer GetSelectedMapLayer() { }

	private static Nullable<MapLayer> GetCurrentUndergroundLayer() { }

	public Vector2 WorldPosToImagePos(Vector3 worldPos) { }

	public Vector3 ImagePosToWorldPos(Vector2 imagePos) { }

	public void CenterOn(Vector3 worldPos) { }

	public void UpdatePlayerPosition(BasePlayer player) { }

	public void DoPlayerUpdate() { }

	public void ClientTeamUpdated(bool positionsOnly = False) { }

	public void LockCurrentLayer() { }

	public void UnlockCurrentLayer() { }

	public void SetCurrentLayer(int layer) { }

	public void UpdateLayerButtons(Nullable<MapLayer> currentLayer) { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct MapView.SleepingBagCluster // TypeDefIndex: 10954
{	public List<RespawnInformation.SpawnOptions> clusterMarkers; // 0x0
	public Vector3 centre; // 0x8

}

private struct MapView.MapMarkerCluster // TypeDefIndex: 10955
{	public List<MapMarker> markers; // 0x0
	public Vector3 centre; // 0x8

}

