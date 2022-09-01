public class MapView : FacepunchBehaviour // TypeDefIndex: 10965
{
	public RawImage mapImage; 
	public Image cameraPositon; 
	public ScrollRectEx scrollRect; 
	public GameObject monumentMarkerContainer; 
	public Transform clusterMarkerContainer; 
	public GameObjectRef monumentMarkerPrefab; 
	public GameObject missionMarkerContainer; 
	public GameObjectRef missionMarkerPrefab; 
	public TeamMemberMapMarker[] teamPositions; 
	public PointOfInterestMapMarker PointOfInterestMarker; 
	public PointOfInterestMapMarker LeaderPointOfInterestMarker; 
	public GameObject PlayerDeathMarker; 
	public List<SleepingBagMapMarker> SleepingBagMarkers; 
	public List<SleepingBagClusterMapMarker> SleepingBagClusters; 
	[FormerlySerializedAsAttribute] 
	public RawImage UndergroundLayer; 
	public bool ShowGrid; 
	public bool ShowPointOfInterestMarkers; 
	public bool ShowDeathMarker; 
	public bool ShowSleepingBags; 
	public bool ShowLocalPlayer; 
	public bool ShowTeamMembers; 
	public bool ShowTrainLayer; 
	public bool ShowMissions; 
	[FormerlySerializedAsAttribute] 
	public bool ShowUndergroundLayers; 
	public bool MLRSMarkerMode; 
	public RustImageButton LockButton; 
	public RustImageButton OverworldButton; 
	public RustImageButton TrainButton; 
	public RustImageButton[] UnderwaterButtons; 
	public static MapView ActiveView; 
	[CompilerGeneratedAttribute] 
	private bool <followingPlayer>k__BackingField; 
	private Dictionary<MapMarker.ClusterType, List<MapMarker>> clusterDict; 
	private List<GameObject> markersToRetire; 
	private Dictionary<MapMarker, GameObject> markerLookup; 
	private List<MonumentMarker> monumentMarkers; 
	private List<MissionMapMarker> missionMarkers; 
	private bool isShowingUndergroundLayers; 
	private Nullable<MapLayer> undergroundLayerOverride; 
	private MapLayer visibleLayer; 
	internal static MapEntity lastActiveMap; 

	public bool followingPlayer { get; set; }
	private bool IsOpen { get; }
	public static float MarkerScale { get; }
	private static BasePlayer LocalPlayerEntity { get; }


	[CompilerGeneratedAttribute] 
	public bool get_followingPlayer() { }

	[CompilerGeneratedAttribute] 
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

private struct MapView.SleepingBagCluster // TypeDefIndex: 10966
{
	public List<RespawnInformation.SpawnOptions> clusterMarkers; 
	public Vector3 centre; 

}

private struct MapView.MapMarkerCluster // TypeDefIndex: 10967
{
	public List<MapMarker> markers; 
	public Vector3 centre; 

}

